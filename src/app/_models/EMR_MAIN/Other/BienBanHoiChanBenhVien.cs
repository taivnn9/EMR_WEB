using EMR.KyDienTu;
using MDB;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class BienBanHoiChanBenhVien : ThongTinKy
    {
        public BienBanHoiChanBenhVien()
        {
            TableName = "BienBanHoiChanBenhVien";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BBHCBV;
            TenMauPhieu = DanhMucPhieu.BBHCBV.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")] 
        public string HoTenBN { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string TuoiBN { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinhBN { get; set; }
        [MoTaDuLieu("Cân nặng")]
		public string CanNang { get; set; }
        [MoTaDuLieu("Chiều cao")]
		public string ChieuCao { get; set; }
        [MoTaDuLieu("Nhóm máu")]
		public string NhomMau { get; set; }
        [MoTaDuLieu("Nghề nghiệp")]
		public string NgheNghiep { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Điện thoại bệnh nhân")]
        public string DienThoai { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh của khoa")]
		public string ChanDoanCuaKhoa { get; set; }
        [MoTaDuLieu("Lý do hội chẩn")]
        public string LyDoHoiChan { get; set; }
        [MoTaDuLieu("Ngày hội chẩn")]
        public DateTime NgayHoiChan { get; set; }
        [MoTaDuLieu("Chủ trì hội chẩn")]
        public string ChuTriHoiChan { get; set; }
        [MoTaDuLieu("Mã nhân viên chủ trì hội chẩn")]
        public string MaNVChuTriHoiChan { get; set; }
        [MoTaDuLieu("Thành viên tham gia hội chẩn")]
        public string ThanhVienThamGia { get; set; }
        [MoTaDuLieu("Mã thành viên tham gia hội chẩn")]
        public string MaNVThanhVienThamGia { get; set; }
        [MoTaDuLieu("Khám lâm sàng")]
        public string KhamLamSang { get; set; }
        [MoTaDuLieu("Điện tâm đồ")]
        public string DienTamDo { get; set; }
        [MoTaDuLieu("Siêu âm tim")]
        public string SieuAmTim { get; set; }
        [MoTaDuLieu("Thông tin chụp động mạch vành")]
        public string TTChupDMV { get; set; }
        [MoTaDuLieu("Xét nghiệm máu, xét nghiệm khác")]
        public string XNMauXNKhac { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh hội chẩn")]
		public string ChanDoanHoiChan { get; set; }
        [MoTaDuLieu("Hướng giải quyết")]
        public string HuongGiaiQuyet { get; set; }
        [MoTaDuLieu("Lãnh đạo khoa lâm sàng")]
        public string LanhDaoKhoaLamSang { get; set; }
        [MoTaDuLieu("Mã lãnh đạo khoa lâm sàng")]
        public string MaNVLanhDaoKhoa { get; set; }
        [MoTaDuLieu("Họ tên chủ trì")]
        public string ChuTri { get; set; }
        [MoTaDuLieu("Mã nhân viên chủ trì")]
        public string MaNVChuTri { get; set; }
        [MoTaDuLieu("Họ tên bác sỹ ngoại")]
        public string BacSyNgoai { get; set; }
        [MoTaDuLieu("Mã bác sỹ ngoại")]
        public string MaBacSyNgoai { get; set; }
        [MoTaDuLieu("Họ tên thư ký")]
        public string ThuKy { get; set; }
        [MoTaDuLieu("Mã thư ký")]
        public string MaThuKy { get; set; }
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
    public class BienBanHoiChanBenhVienFunc
    {
        public const string TableName = "BienBanHoiChanBenhVien";
        public const string TablePrimaryKeyName = "ID";
        public static List<BienBanHoiChanBenhVien> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BienBanHoiChanBenhVien> list = new List<BienBanHoiChanBenhVien>();
            try
            {

                string sql = @"SELECT * FROM BienBanHoiChanBenhVien where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        BienBanHoiChanBenhVien data = new BienBanHoiChanBenhVien();
                        data.ID = DataReader.GetLong("ID");
                        data.MaQuanLy = Convert.ToDecimal(DataReader["MaQuanLy"].ToString());
                        data.MaBenhNhan = DataReader["MABENHNHAN"] != DBNull.Value ? DataReader["MABENHNHAN"].ToString() : "";
                        data.HoTenBN = DataReader["HoTenBN"] != DBNull.Value ? DataReader["HoTenBN"].ToString() : "";
                        data.TuoiBN = DataReader["TuoiBN"] != DBNull.Value ? DataReader["TuoiBN"].ToString() : "";
                        data.GioiTinhBN = DataReader["GioiTinhBN"] != DBNull.Value ? DataReader["GioiTinhBN"].ToString() : "";
                        data.CanNang = DataReader["CanNang"] != DBNull.Value ? DataReader["CanNang"].ToString() : "";
                        data.ChieuCao = DataReader["ChieuCao"] != DBNull.Value ? DataReader["ChieuCao"].ToString() : "";
                        data.NhomMau = DataReader["NhomMau"] != DBNull.Value ? DataReader["NhomMau"].ToString() : "";
                        data.NgheNghiep = DataReader["NgheNghiep"] != DBNull.Value ? DataReader["NgheNghiep"].ToString() : "";
                        data.DiaChi = DataReader["DiaChi"] != DBNull.Value ? DataReader["DiaChi"].ToString() : "";
                        data.DienThoai = DataReader["DienThoai"] != DBNull.Value ? DataReader["DienThoai"].ToString() : "";
                        data.ChanDoanCuaKhoa = DataReader["ChanDoanCuaKhoa"] != DBNull.Value ? DataReader["ChanDoanCuaKhoa"].ToString() : "";
                        data.LyDoHoiChan = DataReader["LyDoHoiChan"] != DBNull.Value ? DataReader["LyDoHoiChan"].ToString() : "";
                        data.NgayHoiChan = ConDB_DateTime(DataReader["NgayHoiChan"]);
                        data.ChuTriHoiChan = DataReader["ChuTriHoiChan"] != DBNull.Value ? DataReader["ChuTriHoiChan"].ToString() : "";
                        data.ThanhVienThamGia = DataReader["ThanhVienThamGia"] != DBNull.Value ? DataReader["ThanhVienThamGia"].ToString() : "";
                        data.KhamLamSang = DataReader["KhamLamSang"] != DBNull.Value ? DataReader["KhamLamSang"].ToString() : "";
                        data.DienTamDo = DataReader["DienTamDo"] != DBNull.Value ? DataReader["DienTamDo"].ToString() : "";
                        data.SieuAmTim = DataReader["SieuAmTim"] != DBNull.Value ? DataReader["SieuAmTim"].ToString() : "";
                        data.TTChupDMV = DataReader["TTChupDMV"] != DBNull.Value ? DataReader["TTChupDMV"].ToString() : "";
                        data.XNMauXNKhac = DataReader["XNMauXNKhac"] != DBNull.Value ? DataReader["XNMauXNKhac"].ToString() : "";
                        data.ChanDoanHoiChan = DataReader["ChanDoanHoiChan"] != DBNull.Value ? DataReader["ChanDoanHoiChan"].ToString() : "";
                        data.HuongGiaiQuyet = DataReader["HuongGiaiQuyet"] != DBNull.Value ? DataReader["HuongGiaiQuyet"].ToString() : "";
                        data.LanhDaoKhoaLamSang = DataReader["LanhDaoKhoaLamSang"] != DBNull.Value ? DataReader["LanhDaoKhoaLamSang"].ToString() : "";
                        data.ChuTri = DataReader["ChuTri"] != DBNull.Value ? DataReader["ChuTri"].ToString() : "";
                        data.NgayTao = ConDB_DateTime(DataReader["NgayTao"]);
                        data.NgaySua = ConDB_DateTime(DataReader["NgaySua"]);
                        data.MaSoKy = DataReader.GetString("masokyten");
                        data.NgayKy = DataReader.GetDate("ngayky");
                        data.TenFileKy = DataReader.GetString("tenfileky");
                        data.UserNameKy = DataReader.GetString("usernameky");
                        data.MaNVChuTriHoiChan = DataReader.GetString("MaNVChuTriHoiChan");
                        data.MaNVLanhDaoKhoa = DataReader.GetString("MaNVLanhDaoKhoa");
                        data.MaNVChuTri = DataReader.GetString("MaNVChuTri");
                        data.MaNVThanhVienThamGia = DataReader.GetString("MaNVThanhVienThamGia");
                        data.BacSyNgoai = DataReader["BacSyNgoai"].ToString();
                        data.MaBacSyNgoai = DataReader["MaBacSyNgoai"].ToString();
                        data.ThuKy = DataReader["ThuKy"].ToString();
                        data.MaThuKy = DataReader["MaThuKy"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BienBanHoiChanBenhVien objData)
        {
            string sql;
            int n = 0;
            if (objData.ID == 0)
            {
                sql = @"INSERT INTO BienBanHoiChanBenhVien (
		                                    MaQuanLy,
		                                    MaBenhNhan,
		                                    HoTenBN,
		                                    TuoiBN,
                                          GioiTinhBN ,
                                          CanNang ,
                                          ChieuCao ,
                                          NhomMau ,
                                          NgheNghiep ,
                                          DiaChi ,
                                          DienThoai ,
                                          ChanDoanCuaKhoa, 
                                          LyDoHoiChan ,
                                          NgayHoiChan ,
                                          ChuTriHoiChan ,
                                          ThanhVienThamGia ,
                                          KhamLamSang,
                                          DienTamDo ,
                                          SieuAmTim ,
                                          TTChupDMV ,
                                          XNMauXNKhac ,
                                          ChanDoanHoiChan, 
                                          HuongGiaiQuyet ,
                                          LanhDaoKhoaLamSang, 
                                          ChuTri  , 
                                        NgayTao ,
                                        NguoiTao ,
                                        MaNVChuTriHoiChan,
                                        MaNVLanhDaoKhoa,
                                        MaNVChuTri,
                                        MaNVThanhVienThamGia,
                                        BacSyNgoai,
                                        MaBacSyNgoai,
                                        ThuKy,
                                        MaThuKy
                )
                VALUES
	             (
		        :MaQuanLy, :MaBenhNhan, :HoTenBN,:TuoiBN,:GioiTinhBN, :CanNang, :ChieuCao, :NhomMau,
		        :NgheNghiep, :DiaChi, :DienThoai, :ChanDoanCuaKhoa,
		        :LyDoHoiChan, :NgayHoiChan, :ChuTriHoiChan, :ThanhVienThamGia,
		        :KhamLamSang, :DienTamDo, :SieuAmTim, :TTChupDMV, :XNMauXNKhac,
                :ChanDoanHoiChan, :HuongGiaiQuyet, :LanhDaoKhoaLamSang, :ChuTri, 
                :NgayTao, :NguoiTao,:MaNVChuTriHoiChan,:MaNVLanhDaoKhoa,:MaNVChuTri,:MaNVThanhVienThamGia,
                :BacSyNgoai,
                :MaBacSyNgoai,
                :ThuKy,
                :MaThuKy
                ) RETURNING ID INTO :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", objData.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", objData.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenBN", objData.HoTenBN));
                Command.Parameters.Add(new MDB.MDBParameter("TuoiBN", objData.TuoiBN));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinhBN", objData.GioiTinhBN));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", objData.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", objData.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("NhomMau", objData.NhomMau));
                Command.Parameters.Add(new MDB.MDBParameter("NgheNghiep", objData.NgheNghiep));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", objData.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("DienThoai", objData.DienThoai));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanCuaKhoa", objData.ChanDoanCuaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("LyDoHoiChan", objData.LyDoHoiChan));
                Command.Parameters.Add(new MDB.MDBParameter("NgayHoiChan", objData.NgayHoiChan));
                Command.Parameters.Add(new MDB.MDBParameter("ChuTriHoiChan", objData.ChuTriHoiChan));
                Command.Parameters.Add(new MDB.MDBParameter("ThanhVienThamGia", objData.ThanhVienThamGia));
                Command.Parameters.Add(new MDB.MDBParameter("KhamLamSang", objData.KhamLamSang));
                Command.Parameters.Add(new MDB.MDBParameter("DienTamDo", objData.DienTamDo));
                Command.Parameters.Add(new MDB.MDBParameter("SieuAmTim", objData.SieuAmTim));
                Command.Parameters.Add(new MDB.MDBParameter("TTChupDMV", objData.TTChupDMV));
                Command.Parameters.Add(new MDB.MDBParameter("XNMauXNKhac", objData.XNMauXNKhac));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanHoiChan", objData.ChanDoanHoiChan));
                Command.Parameters.Add(new MDB.MDBParameter("HuongGiaiQuyet", objData.HuongGiaiQuyet));
                Command.Parameters.Add(new MDB.MDBParameter("LanhDaoKhoaLamSang", objData.LanhDaoKhoaLamSang));
                Command.Parameters.Add(new MDB.MDBParameter("ChuTri", objData.ChuTri));
                Command.Parameters.Add(new MDB.MDBParameter("ID", objData.ID));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTao", DateTime.Now));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiTao", Common.getUserLogin()));
                Command.Parameters.Add(new MDB.MDBParameter("MaNVChuTriHoiChan", objData.MaNVChuTriHoiChan));
                Command.Parameters.Add(new MDB.MDBParameter("MaNVLanhDaoKhoa", objData.MaNVLanhDaoKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaNVChuTri", objData.MaNVChuTri));
                Command.Parameters.Add(new MDB.MDBParameter("MaNVThanhVienThamGia", objData.MaNVThanhVienThamGia));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyNgoai", objData.BacSyNgoai));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyNgoai", objData.MaBacSyNgoai));
                Command.Parameters.Add(new MDB.MDBParameter("ThuKy", objData.ThuKy));
                Command.Parameters.Add(new MDB.MDBParameter("MaThuKy", objData.MaThuKy));

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
            }

            else
            {
                sql = @"UPDATE BienBanHoiChanBenhVien SET 
                                        MaQuanLy=:MaQuanLy,
		                                    MaBenhNhan=:MaBenhNhan,
		                                    HoTenBN=:HoTenBN,
		                                    TuoiBN=:TuoiBN,
                                          GioiTinhBN=:GioiTinhBN ,
                                          CanNang=:CanNang ,
                                          ChieuCao=:ChieuCao ,
                                          NhomMau=:NhomMau ,
                                          NgheNghiep=:NgheNghiep ,
                                          DiaChi=:DiaChi ,
                                          DienThoai=:DienThoai ,
                                          ChanDoanCuaKhoa=:ChanDoanCuaKhoa, 
                                          LyDoHoiChan=:LyDoHoiChan ,
                                          NgayHoiChan=:NgayHoiChan ,
                                          ChuTriHoiChan=:ChuTriHoiChan ,
                                          ThanhVienThamGia=:ThanhVienThamGia ,
                                          KhamLamSang=:KhamLamSang,
                                          DienTamDo=:DienTamDo ,
                                          SieuAmTim=:SieuAmTim ,
                                          TTChupDMV=:TTChupDMV ,
                                          XNMauXNKhac=:XNMauXNKhac ,
                                          ChanDoanHoiChan=:ChanDoanHoiChan, 
                                          HuongGiaiQuyet=:HuongGiaiQuyet ,
                                          LanhDaoKhoaLamSang=:LanhDaoKhoaLamSang, 
                                          ChuTri=:ChuTri  ,  
                                        NgaySua=:NgaySua ,
                                        NguoiSua=:NguoiSua ,
                                        MaNVChuTriHoiChan=:MaNVChuTriHoiChan,
                                        MaNVLanhDaoKhoa=:MaNVLanhDaoKhoa,
                                        MaNVChuTri=:MaNVChuTri,
                                        MaNVThanhVienThamGia=:MaNVThanhVienThamGia,
                                        BacSyNgoai = :BacSyNgoai,
                                        MaBacSyNgoai = :MaBacSyNgoai,
                                        ThuKy = :ThuKy,
                                        MaThuKy= :MaThuKy 
                                        WHERE ID = :IDPhieu";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", objData.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", objData.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenBN", objData.HoTenBN));
                Command.Parameters.Add(new MDB.MDBParameter("TuoiBN", objData.TuoiBN));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinhBN", objData.GioiTinhBN));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", objData.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", objData.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("NhomMau", objData.NhomMau));
                Command.Parameters.Add(new MDB.MDBParameter("NgheNghiep", objData.NgheNghiep));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", objData.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("DienThoai", objData.DienThoai));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanCuaKhoa", objData.ChanDoanCuaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("LyDoHoiChan", objData.LyDoHoiChan));
                Command.Parameters.Add(new MDB.MDBParameter("NgayHoiChan", objData.NgayHoiChan));
                Command.Parameters.Add(new MDB.MDBParameter("ChuTriHoiChan", objData.ChuTriHoiChan));
                Command.Parameters.Add(new MDB.MDBParameter("ThanhVienThamGia", objData.ThanhVienThamGia));
                Command.Parameters.Add(new MDB.MDBParameter("KhamLamSang", objData.KhamLamSang));
                Command.Parameters.Add(new MDB.MDBParameter("DienTamDo", objData.DienTamDo));
                Command.Parameters.Add(new MDB.MDBParameter("SieuAmTim", objData.SieuAmTim));
                Command.Parameters.Add(new MDB.MDBParameter("TTChupDMV", objData.TTChupDMV));
                Command.Parameters.Add(new MDB.MDBParameter("XNMauXNKhac", objData.XNMauXNKhac));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanHoiChan", objData.ChanDoanHoiChan));
                Command.Parameters.Add(new MDB.MDBParameter("HuongGiaiQuyet", objData.HuongGiaiQuyet));
                Command.Parameters.Add(new MDB.MDBParameter("LanhDaoKhoaLamSang", objData.LanhDaoKhoaLamSang));
                Command.Parameters.Add(new MDB.MDBParameter("ChuTri", objData.ChuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NgaySua", DateTime.Now));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiSua", Common.getUserLogin()));
                Command.Parameters.Add(new MDB.MDBParameter("MaNVChuTriHoiChan", objData.MaNVChuTriHoiChan));
                Command.Parameters.Add(new MDB.MDBParameter("MaNVLanhDaoKhoa", objData.MaNVLanhDaoKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaNVChuTri", objData.MaNVChuTri));
                Command.Parameters.Add(new MDB.MDBParameter("MaNVThanhVienThamGia", objData.MaNVThanhVienThamGia));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyNgoai", objData.BacSyNgoai));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyNgoai", objData.MaBacSyNgoai));
                Command.Parameters.Add(new MDB.MDBParameter("ThuKy", objData.ThuKy));
                Command.Parameters.Add(new MDB.MDBParameter("MaThuKy", objData.MaThuKy));
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieu", objData.ID));
                Command.BindByName = true;
                n = Command.ExecuteNonQuery();

            }


            return n > 0 ? true : false;
        }

        public static bool Delete(MDB.MDBConnection MyConnection, decimal idPhieu)
        {
            string sql = "DELETE FROM BienBanHoiChanBenhVien WHERE ID = :idPhieu";
            MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
            command.Parameters.Add(new MDB.MDBParameter("idPhieu", idPhieu));
            command.BindByName = true;
            int n = command.ExecuteNonQuery();
            return n > 0 ? true : false;
        }
        public static BienBanHoiChanBenhVien GetData(MDB.MDBConnection _OracleConnection, decimal id)
        {
            try
            {
                string sql = @"SELECT * FROM BienBanHoiChuanBenhVien where ID = :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", id));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        BienBanHoiChanBenhVien data = new BienBanHoiChanBenhVien();
                        data.ID = DataReader.GetLong("ID");
                        data.MaQuanLy = Convert.ToDecimal(DataReader["MaQuanLy"].ToString());
                        data.MaBenhNhan = DataReader["MABENHNHAN"] != DBNull.Value ? DataReader["MABENHNHAN"].ToString() : "";
                        data.HoTenBN = DataReader["HoTenBN"] != DBNull.Value ? DataReader["HoTenBN"].ToString() : "";
                        data.TuoiBN = DataReader["TuoiBN"] != DBNull.Value ? DataReader["TuoiBN"].ToString() : "";
                        data.GioiTinhBN = DataReader["GioiTinhBN"] != DBNull.Value ? DataReader["GioiTinhBN"].ToString() : "";
                        data.CanNang = DataReader["CanNang"] != DBNull.Value ? DataReader["CanNang"].ToString() : "";
                        data.ChieuCao = DataReader["ChieuCao"] != DBNull.Value ? DataReader["ChieuCao"].ToString() : "";
                        data.NhomMau = DataReader["NhomMau"] != DBNull.Value ? DataReader["NhomMau"].ToString() : "";
                        data.NgheNghiep = DataReader["NgheNghiep"] != DBNull.Value ? DataReader["NgheNghiep"].ToString() : "";
                        data.DiaChi = DataReader["DiaChi"] != DBNull.Value ? DataReader["DiaChi"].ToString() : "";
                        data.DienThoai = DataReader["DienThoai"] != DBNull.Value ? DataReader["DienThoai"].ToString() : "";
                        data.ChanDoanCuaKhoa = DataReader["ChanDoanCuaKhoa"] != DBNull.Value ? DataReader["ChanDoanCuaKhoa"].ToString() : "";
                        data.LyDoHoiChan = DataReader["LyDoHoiChan"] != DBNull.Value ? DataReader["LyDoHoiChan"].ToString() : "";
                        data.NgayHoiChan = ConDB_DateTime(DataReader["NgayHoiChan"]);
                        data.ChuTriHoiChan = DataReader["ChuTriHoiChan"] != DBNull.Value ? DataReader["ChuTriHoiChan"].ToString() : "";
                        data.ThanhVienThamGia = DataReader["ThanhVienThamGia"] != DBNull.Value ? DataReader["ThanhVienThamGia"].ToString() : "";
                        data.KhamLamSang = DataReader["KhamLamSang"] != DBNull.Value ? DataReader["KhamLamSang"].ToString() : "";
                        data.DienTamDo = DataReader["DienTamDo"] != DBNull.Value ? DataReader["DienTamDo"].ToString() : "";
                        data.SieuAmTim = DataReader["SieuAmTim"] != DBNull.Value ? DataReader["SieuAmTim"].ToString() : "";
                        data.TTChupDMV = DataReader["TTChupDMV"] != DBNull.Value ? DataReader["TTChupDMV"].ToString() : "";
                        data.XNMauXNKhac = DataReader["XNMauXNKhac"] != DBNull.Value ? DataReader["XNMauXNKhac"].ToString() : "";
                        data.ChanDoanHoiChan = DataReader["ChanDoanHoiChan"] != DBNull.Value ? DataReader["ChanDoanHoiChan"].ToString() : "";
                        data.HuongGiaiQuyet = DataReader["HuongGiaiQuyet"] != DBNull.Value ? DataReader["HuongGiaiQuyet"].ToString() : "";
                        data.LanhDaoKhoaLamSang = DataReader["LanhDaoKhoaLamSang"] != DBNull.Value ? DataReader["LanhDaoKhoaLamSang"].ToString() : "";
                        data.ChuTri = DataReader["ChuTri"] != DBNull.Value ? DataReader["ChuTri"].ToString() : "";
                        data.NgayTao = ConDB_DateTime(DataReader["NgayTao"]);
                        data.NgaySua = ConDB_DateTime(DataReader["NgaySua"]);
                        data.MaSoKy = DataReader.GetString("masokyten");
                        data.NgayKy = DataReader.GetDate("ngayky");
                        data.TenFileKy = DataReader.GetString("tenfileky");
                        data.UserNameKy = DataReader.GetString("usernameky");
                        data.MaNVChuTriHoiChan = DataReader.GetString("MaNVChuTriHoiChan");
                        data.MaNVLanhDaoKhoa = DataReader.GetString("MaNVLanhDaoKhoa");
                        data.MaNVChuTri = DataReader.GetString("MaNVChuTri");
                        data.MaNVThanhVienThamGia = DataReader.GetString("MaNVThanhVienThamGia");
                        data.BacSyNgoai = DataReader["BacSyNgoai"].ToString();
                        data.MaBacSyNgoai = DataReader["MaBacSyNgoai"].ToString();
                        data.ThuKy = DataReader["ThuKy"].ToString();
                        data.MaThuKy = DataReader["MaThuKy"].ToString();
                        return data;
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
            return null;
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal idPhieu)
        {
            string sql2 = @"SELECT
                D.*,
	            T.KHOA,
	            T.GIUONG,
                T.BUONG,
	            T.NGAYVAOVIEN,
	            H.SOYTE,
	            H.BENHVIEN,
	            H.MABENHNHAN,
	            H.TENBENHNHAN,
	            H.TUOI,
	            H.GIOITINH
            FROM
                BienBanHoiChanBenhVien D
                LEFT JOIN THONGTINDIEUTRI T ON D.MAQUANLY = T.MAQUANLY
                LEFT JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
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
