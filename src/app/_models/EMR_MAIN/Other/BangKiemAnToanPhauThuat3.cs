using EMR.KyDienTu;
using MDB;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class BangKiemAnToanPhauThuatTbl : ThongTinKy
    {
        public BangKiemAnToanPhauThuatTbl()
        {
            TableName = "BangKiemAnToanPhauThuatTbl";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BKATPT2;
            TenMauPhieu = DanhMucPhieu.BKATPT2.Description();
        }


        [MoTaDuLieu("Mã định danh")]
        public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { get; set; }
        public int? TGM_DG1 { get; set; }
        public int? TGM_DG2 { get; set; }
        public int? TGM_DG3 { get; set; }
        public int? TGM_DG4 { get; set; }
        public int? TGM_DG5_1 { get; set; }
        public int? TGM_DG5_2 { get; set; }
        public int? TGM_DG6 { get; set; }
        public int? TGM_DG7 { get; set; }
        public int? TGM_DG8 { get; set; }
        public int? TGM_DG9_1 { get; set; }
        public int? TGM_DG9_2 { get; set; }
        public int? TGM_DG9_3 { get; set; }
        public int? TGM_DG9_4 { get; set; }
        public int? TGM_DG10 { get; set; }
        public int? TGM_DG11_1 { get; set; }
        public int? TGM_DG11_2 { get; set; }
        public int? TGM_DG12 { get; set; }
        public int? TRD_DG2_1 { get; set; }
        public int? TRD_DG2_2 { get; set; }
        public int? TRD_DG2_3 { get; set; }
        public int? TRD_DG2_4 { get; set; }
        public int? TRD_DG3_1 { get; set; }
        public int? TRD_DG3_2 { get; set; }
        public int? TRD_DG4_1 { get; set; }
        public int? TRD_DG4_2 { get; set; }
        public int? TRD_DG5 { get; set; }
        public int? TRD_DG6 { get; set; }
        public int? TCK_DG1 { get; set; }
        public int? TCK_DG2_1 { get; set; }
        public int? TCK_DG2_2 { get; set; }
        public int? TCK_DG3 { get; set; }
        public int? TCK_DG4_1 { get; set; }
        public int? TCK_DG4_2 { get; set; }
        public int? TCK_DG5 { get; set; }
        public int? TCK_DG6 { get; set; }
        public int? LoaiPT { get; set; }
        public int? TRD_DG1_1 { get; set; }
        public int? TRD_DG1_2 { get; set; }
        public int? TRD_DG7 { get; set; }
        public int? TRD_DG8 { get; set; }
        public int? TRD_DG9 { get; set; }
        public int? TRD_DG10 { get; set; }
        [MoTaDuLieu("Thành viên kíp phẫu thuật")]
        public string ThanhVienKipPhauThuat { get; set; }
        public string DanToc
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.DanToc;
            }
        }
        [MoTaDuLieu("Thời gian ca phẫu thuật")]
        public string ThoiGianCPT { get; set; }
        [MoTaDuLieu("Khác")]
        public string Khac { get; set; }
        [MoTaDuLieu("Vấn đề lưu ý")]
        public string VanDeLuuY { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
        public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
        public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
        public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
        public string GioiTinh { get; set; }
        [MoTaDuLieu("Số vào viện")]
        public string SoVaoVien { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
        public string ChanDoan { get; set; }
        [MoTaDuLieu("Phương pháp phẫu thuật")]
        public string pppt { get; set; }
        [MoTaDuLieu("Phương pháp vô cảm")]
        public string ppvc { get; set; }
        [MoTaDuLieu("Mã phẩu thuật viên chính")]
        public string MaPTVC { get; set; }
        [MoTaDuLieu("Họ tên phẫu thuật viên chính")]
        public string TenPTVC { get; set; }
        [MoTaDuLieu("Mã bác sĩ gây mê")]
        public string MaBacsyGM { get; set; }
        [MoTaDuLieu("Họ tên bác sĩ gây mê")]
        public string TenBacsyGM { get; set; }
        [MoTaDuLieu("Mã bác sĩ THNCT")]
        public string MaBacsyTHNCT { get; set; }
        [MoTaDuLieu("Tên bác sĩ THNCT")]
        public string TenBacsyTHNCT { get; set; }
        [MoTaDuLieu("Mã điều dưỡng gây mê")]
        public string MaDDGM { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng gây mê")]
        public string TenDDGM { get; set; }
        [MoTaDuLieu("Mã điều dưỡng THNCT")]
        public string MaDDTHNCT { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng THNCT")]
        public string TenDDTHNCT { get; set; }
        [MoTaDuLieu("Mã điều dưỡng dụng cụ")]
        public string MaDDDC { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng dụng cụ")]
        public string TenDDDC { get; set; }
        [MoTaDuLieu("Khoa")]
        public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
        public string MaKhoa { get; set; }
        [MoTaDuLieu("Ngày vào viện")]
        public DateTime? NgayVaoVien { get; set; }
        [MoTaDuLieu("Ngày vào viện, giờ")]
        public DateTime? NgayVaoVien_Gio { get; set; }
        [MoTaDuLieu("Thời gian phẫu thuật")]
        public DateTime? LucPhauThuat { get; set; }
        [MoTaDuLieu("Thời gian phẫu thuật, giờ")]
        public DateTime? LucPhauThuat_Gio { get; set; }
        [MoTaDuLieu("Nhóm máu")]
        public string NhomMau { get; set; }
        [MoTaDuLieu("Tư thế")]
        public string TuThe { get; set; }
        [MoTaDuLieu("Buồng")]
        public string Buong { get; set; }
        [MoTaDuLieu("Kíp gây mê")]
        public string KipGayMe { get; set; }
        [MoTaDuLieu("Chế phẩm máu")]
        public string ChePhamMau { get; set; }
        [MoTaDuLieu("CD Hình ảnh")]
        public string CDHinhAnh { get; set; }
        [MoTaDuLieu("Cân nặng")]
        public float? CanNang { get; set; }
        [MoTaDuLieu("Ngày thực hiện")]
        public DateTime? ThoiGianThucHien { get; set; }
        [MoTaDuLieu("Giờ thực hiện")]
        public DateTime? ThoiGianThucHien_Gio { get; set; }
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
        [MoTaDuLieu("Chọn", null, 0, 0)]
        public bool Chon { get; set; }
    }
    public class BangKiemAnToanPhauThuatTblFunc
    {
        public const string TableName = "BangKiemAnToanPhauThuatTbl";
        public const string TablePrimaryKeyName = "ID";
        public static List<BangKiemAnToanPhauThuatTbl> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangKiemAnToanPhauThuatTbl> list = new List<BangKiemAnToanPhauThuatTbl>();
            try
            {

                string sql = @"SELECT * FROM BangKiemAnToanPhauThuatTbl where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        BangKiemAnToanPhauThuatTbl data = new BangKiemAnToanPhauThuatTbl();
                        data.ID = DataReader.GetLong("ID");
                        data.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                        data.TGM_DG1 = Common.ConDB_Int(DataReader["TGM_DG1"]);
                        data.TGM_DG2 = Common.ConDB_Int(DataReader["TGM_DG2"]);
                        data.TGM_DG3 = Common.ConDB_Int(DataReader["TGM_DG3"]);
                        data.TGM_DG4 = Common.ConDB_Int(DataReader["TGM_DG4"]);
                        data.TGM_DG5_1 = Common.ConDB_Int(DataReader["TGM_DG5_1"]);
                        data.TGM_DG5_2 = Common.ConDB_Int(DataReader["TGM_DG5_2"]);
                        data.TGM_DG6 = Common.ConDB_Int(DataReader["TGM_DG6"]);
                        data.TGM_DG7 = Common.ConDB_Int(DataReader["TGM_DG7"]);
                        data.TGM_DG8 = Common.ConDB_Int(DataReader["TGM_DG8"]);
                        data.TGM_DG9_1 = Common.ConDB_Int(DataReader["TGM_DG9_1"]);
                        data.TGM_DG9_2 = Common.ConDB_Int(DataReader["TGM_DG9_2"]);
                        data.TGM_DG9_3 = Common.ConDB_Int(DataReader["TGM_DG9_3"]);
                        data.TGM_DG9_4 = Common.ConDB_Int(DataReader["TGM_DG9_4"]);
                        data.TGM_DG10 = Common.ConDB_Int(DataReader["TGM_DG10"]);
                        data.TGM_DG11_1 = Common.ConDB_Int(DataReader["TGM_DG11_1"]);
                        data.TGM_DG11_2 = Common.ConDB_Int(DataReader["TGM_DG11_2"]);
                        data.TGM_DG12 = Common.ConDB_Int(DataReader["TGM_DG12"]);
                        data.TRD_DG2_1 = Common.ConDB_Int(DataReader["TRD_DG2_1"]);
                        data.TRD_DG2_2 = Common.ConDB_Int(DataReader["TRD_DG2_2"]);
                        data.TRD_DG2_3 = Common.ConDB_Int(DataReader["TRD_DG2_3"]);
                        data.TRD_DG2_4 = Common.ConDB_Int(DataReader["TRD_DG2_4"]);
                        data.TRD_DG3_1 = Common.ConDB_Int(DataReader["TRD_DG3_1"]);
                        data.TRD_DG3_2 = Common.ConDB_Int(DataReader["TRD_DG3_2"]);
                        data.TRD_DG4_1 = Common.ConDB_Int(DataReader["TRD_DG4_1"]);
                        data.TRD_DG4_2 = Common.ConDB_Int(DataReader["TRD_DG4_2"]);
                        data.TRD_DG5 = Common.ConDB_Int(DataReader["TRD_DG5"]);
                        data.TRD_DG6 = Common.ConDB_Int(DataReader["TRD_DG6"]);
                        data.TCK_DG1 = Common.ConDB_Int(DataReader["TCK_DG1"]);
                        data.TCK_DG2_1 = Common.ConDB_Int(DataReader["TCK_DG2_1"]);
                        data.TCK_DG2_2 = Common.ConDB_Int(DataReader["TCK_DG2_2"]);
                        data.TCK_DG3 = Common.ConDB_Int(DataReader["TCK_DG3"]);
                        data.TCK_DG4_1 = Common.ConDB_Int(DataReader["TCK_DG4_1"]);
                        data.TCK_DG4_2 = Common.ConDB_Int(DataReader["TCK_DG4_2"]);
                        data.TCK_DG5 = Common.ConDB_Int(DataReader["TCK_DG5"]);
                        data.TCK_DG6 = Common.ConDB_Int(DataReader["TCK_DG6"]);
                        data.LoaiPT = Common.ConDB_Int(DataReader["LoaiPT"]);
                        data.TRD_DG1_1 = Common.ConDB_Int(DataReader["TRD_DG1_1"]);
                        data.TRD_DG1_2 = Common.ConDB_Int(DataReader["TRD_DG1_2"]);
                        data.TRD_DG7 = Common.ConDB_Int(DataReader["TRD_DG7"]);
                        data.TRD_DG8 = Common.ConDB_Int(DataReader["TRD_DG8"]);
                        data.TRD_DG9 = Common.ConDB_Int(DataReader["TRD_DG9"]);
                        data.TRD_DG10 = Common.ConDB_Int(DataReader["TRD_DG10"]);
                        data.ThanhVienKipPhauThuat = Common.ConDBNull(DataReader["ThanhVienKipPhauThuat"]);
                        data.ThoiGianCPT = Common.ConDBNull(DataReader["ThoiGianCPT"]);
                        data.Khac = Common.ConDBNull(DataReader["Khac"]);
                        data.VanDeLuuY = Common.ConDBNull(DataReader["VanDeLuuY"]);
                        data.TenBenhNhan = Common.ConDBNull(DataReader["TenBenhNhan"]);
                        data.MaBenhNhan = Common.ConDBNull(DataReader["MaBenhNhan"]);
                        data.Tuoi = Common.ConDBNull(DataReader["Tuoi"]);
                        data.GioiTinh = Common.ConDBNull(DataReader["GioiTinh"]);
                        data.SoVaoVien = Common.ConDBNull(DataReader["SoVaoVien"]);
                        data.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                        data.pppt = Common.ConDBNull(DataReader["pppt"]);
                        data.ppvc = Common.ConDBNull(DataReader["ppvc"]);
                        data.MaPTVC = Common.ConDBNull(DataReader["MaPTVC"]);
                        data.TenPTVC = Common.ConDBNull(DataReader["TenPTVC"]);
                        data.MaBacsyGM = Common.ConDBNull(DataReader["MaBacsyGM"]);
                        data.TenBacsyGM = Common.ConDBNull(DataReader["TenBacsyGM"]);
                        data.MaBacsyTHNCT = Common.ConDBNull(DataReader["MaBacsyTHNCT"]);
                        data.TenBacsyTHNCT = Common.ConDBNull(DataReader["TenBacsyTHNCT"]);
                        data.MaDDGM = Common.ConDBNull(DataReader["MaDDGM"]);
                        data.TenDDGM = Common.ConDBNull(DataReader["TenDDGM"]);
                        data.MaDDTHNCT = Common.ConDBNull(DataReader["MaDDTHNCT"]);
                        data.TenDDTHNCT = Common.ConDBNull(DataReader["TenDDTHNCT"]);
                        data.MaDDDC = Common.ConDBNull(DataReader["MaDDDC"]);
                        data.TenDDDC = Common.ConDBNull(DataReader["TenDDDC"]);
                        data.Khoa = Common.ConDBNull(DataReader["Khoa"]);
                        data.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                        data.NgayVaoVien = Common.ConDB_DateTimeNull(DataReader["NgayVaoVien"]);
                        data.NgayVaoVien_Gio = data.NgayVaoVien;
                        data.LucPhauThuat = Common.ConDB_DateTimeNull(DataReader["LucPhauThuat"]);
                        data.LucPhauThuat_Gio = data.LucPhauThuat;
                        data.NhomMau = Common.ConDBNull(DataReader["NhomMau"]);
                        data.TuThe = Common.ConDBNull(DataReader["TuThe"]);
                        data.Buong = Common.ConDBNull(DataReader["Buong"]);
                        data.KipGayMe = Common.ConDBNull(DataReader["KipGayMe"]);
                        data.ChePhamMau = Common.ConDBNull(DataReader["ChePhamMau"]);
                        data.CDHinhAnh = Common.ConDBNull(DataReader["CDHinhAnh"]);
                        data.CanNang = Common.ConDBNull_float(DataReader["CanNang"]);
                        data.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                        data.NguoiTao = Common.ConDBNull(DataReader["NguoiTao"]);
                        data.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                        data.NguoiSua = Common.ConDBNull(DataReader["NguoiSua"]);

                        data.ThoiGianThucHien = Common.ConDB_DateTime(DataReader["ThoiGianThucHien"]);
                        data.ThoiGianThucHien_Gio = data.ThoiGianThucHien;


                        data.NgayTao = ConDB_DateTime(DataReader["NgayTao"]);
                        data.NgaySua = ConDB_DateTime(DataReader["NgaySua"]);
                        data.MaSoKy = DataReader.GetString("masokyten");
                        data.NgayKy = DataReader.GetDate("ngayky");
                        data.TenFileKy = DataReader.GetString("tenfileky");
                        data.UserNameKy = DataReader.GetString("usernameky");
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
        public static DateTime ConDB_DateTime(object dbVal)
        {
            DateTime ret = DateTime.MinValue;
            if (dbVal == null)
            {
                return ret;
            }
            bool isSuccess = DateTime.TryParse(dbVal.ToString(), out ret);
            return ret;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangKiemAnToanPhauThuatTbl obj, ref bool isUpdate)
        {
            try
            {
                int n = 0;
                string sql = @"SELECT COUNT(*) RECNUM FROM BangKiemAnToanPhauThuatTbl WHERE ID  = :ID";
                MDB.MDBCommand oracleCommand;
                int rowCount = 0;
                int nRecord = 0;
                oracleCommand = new MDB.MDBCommand(sql, MyConnection);
                oracleCommand.Parameters.Add("ID", obj.ID);
                MDB.MDBDataReader oracleDataReader = oracleCommand.ExecuteReader();
                while (oracleDataReader.Read())
                {
                    rowCount = int.Parse(oracleDataReader["RECNUM"].ToString());
                }


                if (rowCount > 0)
                {
                    isUpdate = true;
                    sql = "update BangKiemAnToanPhauThuatTbl set MaQuanLy = :MaQuanLy, TGM_DG1 = :TGM_DG1, TGM_DG2 = :TGM_DG2, TGM_DG3 = :TGM_DG3, TGM_DG4 = :TGM_DG4, TGM_DG5_1 = :TGM_DG5_1, TGM_DG5_2 = :TGM_DG5_2, TGM_DG6 = :TGM_DG6, TGM_DG7 = :TGM_DG7, TGM_DG8 = :TGM_DG8, TGM_DG9_1 = :TGM_DG9_1, TGM_DG9_2 = :TGM_DG9_2, TGM_DG9_3 = :TGM_DG9_3, TGM_DG9_4 = :TGM_DG9_4, TGM_DG10 = :TGM_DG10, TGM_DG11_1 = :TGM_DG11_1, TGM_DG11_2 = :TGM_DG11_2, TGM_DG12 = :TGM_DG12, TRD_DG2_1 = :TRD_DG2_1, TRD_DG2_2 = :TRD_DG2_2, TRD_DG2_3 = :TRD_DG2_3, TRD_DG2_4 = :TRD_DG2_4, TRD_DG3_1 = :TRD_DG3_1, TRD_DG3_2 = :TRD_DG3_2, TRD_DG4_1 = :TRD_DG4_1, TRD_DG4_2 = :TRD_DG4_2, TRD_DG5 = :TRD_DG5, TRD_DG6 = :TRD_DG6, TCK_DG1 = :TCK_DG1, TCK_DG2_1 = :TCK_DG2_1, TCK_DG2_2 = :TCK_DG2_2, TCK_DG3 = :TCK_DG3, TCK_DG4_1 = :TCK_DG4_1, TCK_DG4_2 = :TCK_DG4_2, TCK_DG5 = :TCK_DG5, TCK_DG6 = :TCK_DG6, LoaiPT = :LoaiPT, TRD_DG1_1 = :TRD_DG1_1, TRD_DG1_2 = :TRD_DG1_2,TRD_DG7 = :TRD_DG7,TRD_DG8 = :TRD_DG8,TRD_DG9 = :TRD_DG9,TRD_DG10 = :TRD_DG10, ThanhVienKipPhauThuat = :ThanhVienKipPhauThuat, ThoiGianCPT = :ThoiGianCPT, Khac = :Khac, VanDeLuuY = :VanDeLuuY, TenBenhNhan = :TenBenhNhan,MaBenhNhan = :MaBenhNhan, Tuoi = :Tuoi, GioiTinh = :GioiTinh, SoVaoVien = :SoVaoVien, ChanDoan = :ChanDoan, pppt = :pppt, ppvc = :ppvc, MaPTVC = :MaPTVC, TenPTVC = :TenPTVC, MaBacsyGM = :MaBacsyGM, TenBacsyGM = :TenBacsyGM, MaBacsyTHNCT = :MaBacsyTHNCT, TenBacsyTHNCT = :TenBacsyTHNCT, MaDDGM = :MaDDGM, TenDDGM = :TenDDGM, MaDDTHNCT = :MaDDTHNCT, TenDDTHNCT = :TenDDTHNCT, MaDDDC = :MaDDDC, TenDDDC = :TenDDDC, Khoa = :Khoa, MaKhoa = :MaKhoa,NgayVaoVien =:NgayVaoVien,LucPhauThuat =:LucPhauThuat, NhomMau =:NhomMau, TuThe =:TuThe, Buong =:Buong, KipGayMe =:KipGayMe, ChePhamMau =:ChePhamMau, CDHinhAnh =:CDHinhAnh, CanNang =:CanNang, ThoiGianThucHien = :ThoiGianThucHien, NgayTao = :NgayTao, NguoiTao = :NguoiTao, NgaySua = :NgaySua, NguoiSua = :NguoiSua";
                    sql = sql + " WHERE ID  = " + obj.ID.ToString();
                }
                else
                {
                    sql = @"insert into BangKiemAnToanPhauThuatTbl(MaQuanLy,TGM_DG1,TGM_DG2,TGM_DG3,TGM_DG4,TGM_DG5_1,TGM_DG5_2,TGM_DG6,TGM_DG7,TGM_DG8,TGM_DG9_1,TGM_DG9_2,TGM_DG9_3,TGM_DG9_4,TGM_DG10,TGM_DG11_1,TGM_DG11_2,TGM_DG12,TRD_DG2_1,TRD_DG2_2,TRD_DG2_3,TRD_DG2_4,TRD_DG3_1,TRD_DG3_2,TRD_DG4_1,TRD_DG4_2,TRD_DG5,TRD_DG6,TCK_DG1,TCK_DG2_1,TCK_DG2_2,TCK_DG3,TCK_DG4_1,TCK_DG4_2,TCK_DG5,TCK_DG6,LoaiPT,TRD_DG1_1,TRD_DG1_2,TRD_DG7,TRD_DG8,TRD_DG9,TRD_DG10,ThanhVienKipPhauThuat, ThoiGianCPT,Khac,VanDeLuuY,TenBenhNhan,MaBenhNhan,Tuoi,GioiTinh,SoVaoVien,ChanDoan,pppt,ppvc,MaPTVC,TenPTVC,MaBacsyGM,TenBacsyGM,MaBacsyTHNCT,TenBacsyTHNCT,MaDDGM,TenDDGM,MaDDTHNCT,TenDDTHNCT,MaDDDC,TenDDDC,Khoa,MaKhoa,NgayVaoVien ,LucPhauThuat , NhomMau , TuThe , Buong, KipGayMe , ChePhamMau, CDHinhAnh, CanNang,ThoiGianThucHien,NgayTao,NguoiTao,NgaySua,NguoiSua" +
                        ")";
                    sql = sql + @"Values(:MaQuanLy, :TGM_DG1, :TGM_DG2, :TGM_DG3, :TGM_DG4, :TGM_DG5_1, :TGM_DG5_2, :TGM_DG6, :TGM_DG7, :TGM_DG8, :TGM_DG9_1, :TGM_DG9_2, :TGM_DG9_3, :TGM_DG9_4, :TGM_DG10, :TGM_DG11_1, :TGM_DG11_2, :TGM_DG12, :TRD_DG2_1, :TRD_DG2_2, :TRD_DG2_3, :TRD_DG2_4, :TRD_DG3_1, :TRD_DG3_2, :TRD_DG4_1, :TRD_DG4_2, :TRD_DG5, :TRD_DG6, :TCK_DG1, :TCK_DG2_1, :TCK_DG2_2, :TCK_DG3, :TCK_DG4_1, :TCK_DG4_2, :TCK_DG5, :TCK_DG6, :LoaiPT, :TRD_DG1_1, :TRD_DG1_2,:TRD_DG7, :TRD_DG8,:TRD_DG9,:TRD_DG10, :ThanhVienKipPhauThuat, :ThoiGianCPT, :Khac, :VanDeLuuY, :TenBenhNhan, :MaBenhNhan, :Tuoi, :GioiTinh, :SoVaoVien, :ChanDoan, :pppt, :ppvc, :MaPTVC, :TenPTVC, :MaBacsyGM, :TenBacsyGM, :MaBacsyTHNCT, :TenBacsyTHNCT, :MaDDGM, :TenDDGM, :MaDDTHNCT, :TenDDTHNCT, :MaDDDC, :TenDDDC, :Khoa, :MaKhoa, :NgayVaoVien, :LucPhauThuat, :NhomMau, :TuThe, :Buong, :KipGayMe, :ChePhamMau, :CDHinhAnh, :CanNang, :ThoiGianThucHien, :NgayTao, :NguoiTao, :NgaySua, :NguoiSua" +
                        ")   RETURNING ID INTO :ID";
                }
                oracleCommand = new MDB.MDBCommand(sql, MyConnection);
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TGM_DG1", obj.TGM_DG1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TGM_DG2", obj.TGM_DG2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TGM_DG3", obj.TGM_DG3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TGM_DG4", obj.TGM_DG4));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TGM_DG5_1", obj.TGM_DG5_1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TGM_DG5_2", obj.TGM_DG5_2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TGM_DG6", obj.TGM_DG6));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TGM_DG7", obj.TGM_DG7));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TGM_DG8", obj.TGM_DG8));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TGM_DG9_1", obj.TGM_DG9_1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TGM_DG9_2", obj.TGM_DG9_2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TGM_DG9_3", obj.TGM_DG9_3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TGM_DG9_4", obj.TGM_DG9_4));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TGM_DG10", obj.TGM_DG10));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TGM_DG11_1", obj.TGM_DG11_1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TGM_DG11_2", obj.TGM_DG11_2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TGM_DG12", obj.TGM_DG12));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TRD_DG2_1", obj.TRD_DG2_1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TRD_DG2_2", obj.TRD_DG2_2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TRD_DG2_3", obj.TRD_DG2_3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TRD_DG2_4", obj.TRD_DG2_4));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TRD_DG3_1", obj.TRD_DG3_1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TRD_DG3_2", obj.TRD_DG3_2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TRD_DG4_1", obj.TRD_DG4_1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TRD_DG4_2", obj.TRD_DG4_2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TRD_DG5", obj.TRD_DG5));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TRD_DG6", obj.TRD_DG6));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TCK_DG1", obj.TCK_DG1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TCK_DG2_1", obj.TCK_DG2_1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TCK_DG2_2", obj.TCK_DG2_2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TCK_DG3", obj.TCK_DG3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TCK_DG4_1", obj.TCK_DG4_1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TCK_DG4_2", obj.TCK_DG4_2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TCK_DG5", obj.TCK_DG5));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TCK_DG6", obj.TCK_DG6));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("LoaiPT", obj.LoaiPT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TRD_DG1_1", obj.TRD_DG1_1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TRD_DG1_2", obj.TRD_DG1_2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TRD_DG7", obj.TRD_DG7));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TRD_DG8", obj.TRD_DG8));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TRD_DG9", obj.TRD_DG9));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TRD_DG10", obj.TRD_DG10));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThanhVienKipPhauThuat", obj.ThanhVienKipPhauThuat));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGianCPT", obj.ThoiGianCPT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Khac", obj.Khac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("VanDeLuuY", obj.VanDeLuuY));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenBenhNhan", obj.TenBenhNhan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Tuoi", obj.Tuoi));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("GioiTinh", obj.GioiTinh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SoVaoVien", obj.SoVaoVien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChanDoan", obj.ChanDoan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("pppt", obj.pppt));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ppvc", obj.ppvc));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaPTVC", obj.MaPTVC));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenPTVC", obj.TenPTVC));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBacsyGM", obj.MaBacsyGM));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenBacsyGM", obj.TenBacsyGM));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBacsyTHNCT", obj.MaBacsyTHNCT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenBacsyTHNCT", obj.TenBacsyTHNCT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaDDGM", obj.MaDDGM));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenDDGM", obj.TenDDGM));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaDDTHNCT", obj.MaDDTHNCT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenDDTHNCT", obj.TenDDTHNCT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaDDDC", obj.MaDDDC));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenDDDC", obj.TenDDDC));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Khoa", obj.Khoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaKhoa", obj.MaKhoa));
                DateTime? NgayVaoVien = obj.NgayVaoVien.HasValue ? obj.NgayVaoVien.Value.Date : (DateTime?)null;
                var NgayVaoVien_PT = NgayVaoVien;
                if (NgayVaoVien != null)
                {
                    var NgayVaoVien_Gio = obj.NgayVaoVien_Gio.HasValue ? obj.NgayVaoVien_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    NgayVaoVien_PT = NgayVaoVien + NgayVaoVien_Gio;
                }
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", NgayVaoVien_PT));

                DateTime? NgayPhauThuat = obj.LucPhauThuat.HasValue ? obj.LucPhauThuat.Value.Date : (DateTime?)null;
                var ThoiGian_PT = NgayPhauThuat;
                if (NgayPhauThuat != null)
                {
                    var NgayPhauThuat_Gio = obj.LucPhauThuat_Gio.HasValue ? obj.LucPhauThuat_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    ThoiGian_PT = NgayPhauThuat + NgayPhauThuat_Gio;
                }
                oracleCommand.Parameters.Add(new MDB.MDBParameter("LucPhauThuat", ThoiGian_PT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NhomMau", obj.NhomMau));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TuThe", obj.TuThe));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Buong", obj.Buong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KipGayMe", obj.KipGayMe));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChePhamMau", obj.ChePhamMau));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CDHinhAnh", obj.CDHinhAnh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CanNang", obj.CanNang));

                DateTime? ThoiGianThucHien = obj.ThoiGianThucHien.HasValue ? obj.ThoiGianThucHien.Value.Date : (DateTime?)null;
                var ThoiGian = ThoiGianThucHien;
                if (ThoiGianThucHien != null)
                {
                    var ThoiGianThucHien_Gio = obj.ThoiGianThucHien_Gio.HasValue ? obj.ThoiGianThucHien_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    ThoiGian = ThoiGianThucHien + ThoiGianThucHien_Gio;
                }
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGianThucHien", ThoiGian));

                if (isUpdate)
                {
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTao", obj.NgayTao));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiTao", obj.NguoiTao));
                }
                else
                {
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTao", DateTime.Now));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiTao", Common.getUserLogin()));
                }
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgaySua", DateTime.Now));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiSua", Common.getUserLogin()));


                if (!isUpdate)
                {
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ID", obj.ID));
                }
                nRecord = oracleCommand.ExecuteNonQuery();
                if (nRecord > 0)
                {
                    if (!isUpdate)
                    {
                        long nextval = (long)((oracleCommand.Parameters["ID"] as MDB.MDBParameter).Value);
                        obj.ID = nextval;
                    }
                }
                return nRecord > 0 ? true : false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }

        public static bool Delete(MDB.MDBConnection MyConnection, decimal idPhieu)
        {
            string sql = "DELETE FROM BangKiemAnToanPhauThuatTbl WHERE ID = :idPhieu";
            MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
            command.Parameters.Add(new MDB.MDBParameter("idPhieu", idPhieu));
            command.BindByName = true;
            int n = command.ExecuteNonQuery();
            return n > 0 ? true : false;
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal idPhieu)
        {
            string sql2 = @"SELECT
                D.* 
            FROM
                BangKiemAnToanPhauThuatTbl D
            WHERE
                ID = :ID";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql2, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("ID", idPhieu));

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds, "BK");
            return ds;
        }
    }
}
