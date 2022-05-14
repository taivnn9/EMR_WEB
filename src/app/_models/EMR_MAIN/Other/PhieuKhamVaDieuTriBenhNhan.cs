using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors.Filtering.Templates;
using EMR.KyDienTu;
using EMR_MAIN.ChucNangKhac;
using MDB;
using Newtonsoft.Json;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuKhamVaDieuTriBenhNhan : ThongTinKy
    {
        public PhieuKhamVaDieuTriBenhNhan()
        {
            TableName = "PhieuKhamVaDieuTriBenhNhan";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PKVDTBN;
            TenMauPhieu = DanhMucPhieu.PKVDTBN.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Nghề nghiệp")]
		public string NgheNghiep { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        public string TheBaoHiem { get; set; }
        public DateTime TheBHTuNgay { get; set; }
        public DateTime TheBHDenNgay { get; set; }
        public string TTKhiCanLienHe { get; set; }
        public string DienThoai { get; set; }
        public DateTime ThoiGianVaoKhoa { get; set; }
        public string LyDoVaoVien { get; set; }
        public string[] TomTatArray { get; set; } = new string[1];
        public string TienSuDiUng { get; set; }
        public string[] TinhTrangLucVaoVien { get; set; } = new string[1];
        [MoTaDuLieu("Mạch")]
		public string Mach { get; set; }
        [MoTaDuLieu("Nhiệt độ")]
		public string NhietDo { get; set; }
        [MoTaDuLieu("Huyết áp")]
		public string HuyetAp { get; set; }
        [MoTaDuLieu("Nhịp thở")]
		public string NhipTho { get; set; }
        [MoTaDuLieu("Cân nặng")]
		public string CanNang { get; set; }
        [MoTaDuLieu("Chiều cao")]
		public string ChieuCao { get; set; }
        public string[] CacXetNghiem { get; set; } = new string[1];
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoanSoBo { get; set; }
        public string HuongDieuTri { get; set; }
        public DateTime ThoiGianThucHien { get; set; }
        [MoTaDuLieu("Mã bác sỹ khám bệnh")]
        public string MaNVBacSyKhamBenh { get; set; }
        [MoTaDuLieu("Bác sỹ khám bệnh")]
        public string BacSyKhamBenh { get; set; }

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
    public class PhieuKhamVaDieuTriBenhNhanFunc
    {
        public const string TableName = "PhieuKhamVaDieuTriBenhNhan";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuKhamVaDieuTriBenhNhan> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuKhamVaDieuTriBenhNhan> list = new List<PhieuKhamVaDieuTriBenhNhan>();
            try
            {

                string sql = @"SELECT * FROM PhieuKhamVaDieuTriBenhNhan where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        PhieuKhamVaDieuTriBenhNhan data = new PhieuKhamVaDieuTriBenhNhan();
                        data.ID = DataReader.GetLong("id");
                        data.MaQuanLy = DataReader.GetDecimal("maquanly");
                        data.MaBenhNhan = DataReader.GetString("mabenhnhan");
                        data.TenBenhNhan = DataReader.GetString("tenbenhnhan");
                        data.Tuoi = DataReader.GetString("tuoi");
                        data.GioiTinh = DataReader.GetString("gioitinh");
                        data.Khoa = DataReader.GetString("khoa");
                        data.NgheNghiep = DataReader.GetString("nghenghiep");
                        data.DiaChi = DataReader.GetString("diachi");
                        data.TheBaoHiem = DataReader.GetString("thebaohiem");
                        data.TheBHTuNgay = ConDB_DateTime(DataReader["thebhtungay"]);
                        data.TheBHDenNgay = ConDB_DateTime(DataReader["TheBHDenNgay"]);
                        data.TTKhiCanLienHe = DataReader.GetString("ttkhicanlienhe");
                        data.DienThoai = DataReader.GetString("DienThoai");
                        data.ThoiGianVaoKhoa = ConDB_DateTime(DataReader["ThoiGianVaoKhoa"]);
                        data.LyDoVaoVien = DataReader.GetString("lydovaovien");
                        data.TomTatArray = JsonConvert.DeserializeObject<string[]>(DataReader.GetString("tomtattsbs"));
                        data.TienSuDiUng = DataReader.GetString("tiensudiung");
                        data.TinhTrangLucVaoVien = JsonConvert.DeserializeObject<string[]>(DataReader.GetString("tinhtranglucvaovien"));
                        data.Mach = DataReader.GetString("mach");
                        data.NhietDo = DataReader.GetString("nhietdo");
                        data.HuyetAp = DataReader.GetString("huyetap");
                        data.NhipTho = DataReader.GetString("nhiptho");
                        data.CanNang = DataReader.GetString("cannang");
                        data.ChieuCao = DataReader.GetString("chieucao");
                        data.CacXetNghiem = JsonConvert.DeserializeObject<string[]>(DataReader.GetString("cacxetnghiem"));
                        data.ChanDoanSoBo = DataReader.GetString("chandoansobo");
                        data.HuongDieuTri = DataReader.GetString("huongdieutri");
                        data.ThoiGianThucHien = ConDB_DateTime(DataReader["thoigianthuchien"]);
                        data.MaNVBacSyKhamBenh = DataReader.GetString("manvbacsykhambenh");
                        data.BacSyKhamBenh = DataReader.GetString("bacsykhambenh");
                        data.NguoiTao = DataReader.GetString("NguoiTao");
                        data.NguoiSua = DataReader.GetString("NguoiSua");
                        data.NgayTao = ConDB_DateTime(DataReader["NgayTao"]);
                        data.NgaySua = ConDB_DateTime(DataReader["NgaySua"]);
                        data.MaSoKy = DataReader.GetString("masokyten");
                        data.NgayKy = DataReader.GetDate("ngayky");
                        data.TenFileKy = DataReader.GetString("tenfileky");
                        data.UserNameKy = DataReader.GetString("usernameky");
                        data.ComputerKyTen = DataReader.GetString("COMPUTERKYTEN");

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuKhamVaDieuTriBenhNhan objData)
        {
            string sql;
            int n = 0;
            if (objData.ID == 0)
            {
                sql = @"INSERT INTO PhieuKhamVaDieuTriBenhNhan (
                                    maquanly,
                                    mabenhnhan,
                                    tenbenhnhan,
                                    tuoi,
                                    gioitinh,
                                    khoa,
                                    nghenghiep,
                                    diachi,
                                    thebaohiem,
                                    thebhtungay,
                                    thebhdenngay,
                                    ttkhicanlienhe,
                                    DienThoai,
                                    thoigianvaokhoa,
                                    lydovaovien,
                                    tomtattsbs,
                                    tiensudiung,
                                    tinhtranglucvaovien,
                                    mach,
                                    nhietdo,
                                    huyetap,
                                    nhiptho,
                                    cannang,
                                    chieucao,
                                    cacxetnghiem,
                                    chandoansobo,
                                    huongdieutri,
                                    thoigianthuchien,
                                    manvbacsykhambenh,
                                    bacsykhambenh,
                                    nguoitao,
                                    ngaytao
                                ) VALUES (
                                    :maquanly,
                                    :mabenhnhan,
                                    :tenbenhnhan,
                                    :tuoi,
                                    :gioitinh,
                                    :khoa,
                                    :nghenghiep,
                                    :diachi,
                                    :thebaohiem,
                                    :thebhtungay,
                                    :thebhdenngay,
                                    :ttkhicanlienhe,
                                    :DienThoai,
                                    :thoigianvaokhoa,
                                    :lydovaovien,
                                    :tomtattsbs,
                                    :tiensudiung,
                                    :tinhtranglucvaovien,
                                    :mach,
                                    :nhietdo,
                                    :huyetap,
                                    :nhiptho,
                                    :cannang,
                                    :chieucao,
                                    :cacxetnghiem,
                                    :chandoansobo,
                                    :huongdieutri,
                                    :thoigianthuchien,
                                    :manvbacsykhambenh,
                                    :bacsykhambenh,
                                    :nguoitao,
                                    :ngaytao 
                                ) RETURNING ID INTO :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("maquanly", objData.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("mabenhnhan", objData.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("tenbenhnhan", objData.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("tuoi", objData.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("gioitinh", objData.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("khoa", objData.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("nghenghiep", objData.NgheNghiep));
                Command.Parameters.Add(new MDB.MDBParameter("diachi", objData.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("thebaohiem", objData.TheBaoHiem));
                Command.Parameters.Add(new MDB.MDBParameter("thebhtungay", objData.TheBHTuNgay));
                Command.Parameters.Add(new MDB.MDBParameter("thebhdenngay", objData.TheBHDenNgay));
                Command.Parameters.Add(new MDB.MDBParameter("ttkhicanlienhe", objData.TTKhiCanLienHe));
                Command.Parameters.Add(new MDB.MDBParameter("DienThoai", objData.DienThoai));
                Command.Parameters.Add(new MDB.MDBParameter("thoigianvaokhoa", objData.ThoiGianVaoKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("lydovaovien", objData.LyDoVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("tomtattsbs", JsonConvert.SerializeObject(objData.TomTatArray)));
                Command.Parameters.Add(new MDB.MDBParameter("tiensudiung", objData.TienSuDiUng));
                Command.Parameters.Add(new MDB.MDBParameter("tinhtranglucvaovien", JsonConvert.SerializeObject(objData.TinhTrangLucVaoVien)));
                Command.Parameters.Add(new MDB.MDBParameter("mach", objData.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("nhietdo", objData.NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("huyetap", objData.HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("nhiptho", objData.NhipTho));
                Command.Parameters.Add(new MDB.MDBParameter("cannang", objData.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("chieucao", objData.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("cacxetnghiem", JsonConvert.SerializeObject(objData.CacXetNghiem)));
                Command.Parameters.Add(new MDB.MDBParameter("chandoansobo", objData.ChanDoanSoBo));
                Command.Parameters.Add(new MDB.MDBParameter("huongdieutri", objData.HuongDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("thoigianthuchien", objData.ThoiGianThucHien));
                Command.Parameters.Add(new MDB.MDBParameter("manvbacsykhambenh", objData.MaNVBacSyKhamBenh));
                Command.Parameters.Add(new MDB.MDBParameter("bacsykhambenh", objData.BacSyKhamBenh));
                Command.Parameters.Add(new MDB.MDBParameter("ID", objData.ID));
                Command.Parameters.Add(new MDB.MDBParameter("nguoitao", objData.NguoiTao));
                Command.Parameters.Add(new MDB.MDBParameter("ngaytao", objData.NgayTao));
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
                sql = @"UPDATE PhieuKhamVaDieuTriBenhNhan SET  
                                        maquanly=:maquanly,
                                        mabenhnhan=:mabenhnhan,
                                        tenbenhnhan=:tenbenhnhan,
                                        tuoi=:tuoi,
                                        gioitinh=:gioitinh,
                                        khoa=:khoa,
                                        nghenghiep=:nghenghiep,
                                        diachi=:diachi,
                                        thebaohiem=:thebaohiem,
                                        thebhtungay=:thebhtungay,
                                        thebhdenngay=:thebhdenngay,
                                        ttkhicanlienhe=:ttkhicanlienhe,
                                        DienThoai=:DienThoai,
                                        thoigianvaokhoa=:thoigianvaokhoa,
                                        lydovaovien=:lydovaovien,
                                        tomtattsbs=:tomtattsbs,
                                        tiensudiung=:tiensudiung,
                                        tinhtranglucvaovien=:tinhtranglucvaovien,
                                        mach=:mach,
                                        nhietdo=:nhietdo,
                                        huyetap=:huyetap,
                                        nhiptho=:nhiptho,
                                        cannang=:cannang,
                                        chieucao=:chieucao,
                                        cacxetnghiem=:cacxetnghiem,
                                        chandoansobo=:chandoansobo,
                                        huongdieutri=:huongdieutri,
                                        thoigianthuchien=:thoigianthuchien,
                                        manvbacsykhambenh=:manvbacsykhambenh,
                                        bacsykhambenh=:bacsykhambenh,
                                        nguoisua = :nguoisua,
                                        ngaysua = :ngaysua 
                                        WHERE ID = :IDPhieu";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("maquanly", objData.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("mabenhnhan", objData.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("tenbenhnhan", objData.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("tuoi", objData.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("gioitinh", objData.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("khoa", objData.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("nghenghiep", objData.NgheNghiep));
                Command.Parameters.Add(new MDB.MDBParameter("diachi", objData.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("thebaohiem", objData.TheBaoHiem));
                Command.Parameters.Add(new MDB.MDBParameter("thebhtungay", objData.TheBHTuNgay));
                Command.Parameters.Add(new MDB.MDBParameter("thebhdenngay", objData.TheBHDenNgay));
                Command.Parameters.Add(new MDB.MDBParameter("ttkhicanlienhe", objData.TTKhiCanLienHe));
                Command.Parameters.Add(new MDB.MDBParameter("DienThoai", objData.DienThoai));
                Command.Parameters.Add(new MDB.MDBParameter("thoigianvaokhoa", objData.ThoiGianVaoKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("lydovaovien", objData.LyDoVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("tomtattsbs", JsonConvert.SerializeObject(objData.TomTatArray)));
                Command.Parameters.Add(new MDB.MDBParameter("tiensudiung", objData.TienSuDiUng));
                Command.Parameters.Add(new MDB.MDBParameter("tinhtranglucvaovien", JsonConvert.SerializeObject(objData.TinhTrangLucVaoVien)));
                Command.Parameters.Add(new MDB.MDBParameter("mach", objData.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("nhietdo", objData.NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("huyetap", objData.HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("nhiptho", objData.NhipTho));
                Command.Parameters.Add(new MDB.MDBParameter("cannang", objData.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("chieucao", objData.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("cacxetnghiem", JsonConvert.SerializeObject(objData.CacXetNghiem)));
                Command.Parameters.Add(new MDB.MDBParameter("chandoansobo", objData.ChanDoanSoBo));
                Command.Parameters.Add(new MDB.MDBParameter("huongdieutri", objData.HuongDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("thoigianthuchien", objData.ThoiGianThucHien));
                Command.Parameters.Add(new MDB.MDBParameter("manvbacsykhambenh", objData.MaNVBacSyKhamBenh));
                Command.Parameters.Add(new MDB.MDBParameter("bacsykhambenh", objData.BacSyKhamBenh));
                Command.Parameters.Add(new MDB.MDBParameter("nguoisua", objData.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("ngaysua", objData.NgaySua));
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieu", objData.ID));
                Command.BindByName = true;
                n = Command.ExecuteNonQuery();

            }


            return n > 0 ? true : false;
        }

        public static bool Delete(MDB.MDBConnection MyConnection, decimal idPhieu)
        {
            string sql = "DELETE FROM PhieuKhamVaDieuTriBenhNhan WHERE ID = :idPhieu";
            MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
            command.Parameters.Add(new MDB.MDBParameter("idPhieu", idPhieu));
            command.BindByName = true;
            int n = command.ExecuteNonQuery();
            return n > 0 ? true : false;
        }
        public static PhieuKhamVaDieuTriBenhNhan GetData(MDB.MDBConnection _OracleConnection, decimal id)
        {
            try
            {
                string sql = @"SELECT * FROM PhieuKhamVaDieuTriBenhNhan where ID = :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", id));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        PhieuKhamVaDieuTriBenhNhan data = new PhieuKhamVaDieuTriBenhNhan();
                        data.ID = DataReader.GetLong("id");
                        data.MaQuanLy = DataReader.GetDecimal("maquanly");
                        data.MaBenhNhan = DataReader.GetString("mabenhnhan");
                        data.TenBenhNhan = DataReader.GetString("tenbenhnhan");
                        data.Tuoi = DataReader.GetString("tuoi");
                        data.GioiTinh = DataReader.GetString("gioitinh");
                        data.Khoa = DataReader.GetString("khoa");
                        data.NgheNghiep = DataReader.GetString("nghenghiep");
                        data.DiaChi = DataReader.GetString("diachi");
                        data.TheBaoHiem = DataReader.GetString("thebaohiem");
                        data.TheBHTuNgay = ConDB_DateTime(DataReader["thebhtungay"]);
                        data.TheBHDenNgay = ConDB_DateTime(DataReader["TheBHDenNgay"]);
                        data.TTKhiCanLienHe = DataReader.GetString("ttkhicanlienhe");
                        data.DienThoai = DataReader.GetString("DienThoai");
                        data.ThoiGianVaoKhoa = ConDB_DateTime(DataReader["ThoiGianVaoKhoa"]);
                        data.LyDoVaoVien = DataReader.GetString("lydovaovien");
                        data.TomTatArray = JsonConvert.DeserializeObject<string[]>(DataReader.GetString("tomtattsbs"));
                        data.TienSuDiUng = DataReader.GetString("tiensudiung");
                        data.TinhTrangLucVaoVien = JsonConvert.DeserializeObject<string[]>(DataReader.GetString("tinhtranglucvaovien"));
                        data.Mach = DataReader.GetString("mach");
                        data.NhietDo = DataReader.GetString("nhietdo");
                        data.HuyetAp = DataReader.GetString("huyetap");
                        data.NhipTho = DataReader.GetString("nhiptho");
                        data.CanNang = DataReader.GetString("cannang");
                        data.ChieuCao = DataReader.GetString("chieucao");
                        data.CacXetNghiem = JsonConvert.DeserializeObject<string[]>(DataReader.GetString("cacxetnghiem"));
                        data.ChanDoanSoBo = DataReader.GetString("chandoansobo");
                        data.HuongDieuTri = DataReader.GetString("huongdieutri");
                        data.ThoiGianThucHien = ConDB_DateTime(DataReader["thoigianthuchien"]);
                        data.MaNVBacSyKhamBenh = DataReader.GetString("manvbacsykhambenh");
                        data.BacSyKhamBenh = DataReader.GetString("bacsykhambenh");
                        data.NguoiTao = DataReader.GetString("NguoiTao");
                        data.NguoiSua = DataReader.GetString("NguoiSua");
                        data.NgayTao = ConDB_DateTime(DataReader["NgayTao"]);
                        data.NgaySua = ConDB_DateTime(DataReader["NgaySua"]);
                        data.MaSoKy = DataReader.GetString("masokyten");
                        data.NgayKy = DataReader.GetDate("ngayky");
                        data.TenFileKy = DataReader.GetString("tenfileky");
                        data.UserNameKy = DataReader.GetString("usernameky");
                        data.ComputerKyTen = DataReader.GetString("COMPUTERKYTEN");

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
	            T.MABENHNHAN,
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
                PhieuKhamVaDieuTriBenhNhan D
                LEFT JOIN THONGTINDIEUTRI T ON D.MAQUANLY = T.MAQUANLY
                LEFT JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                ID = :ID";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql2, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("ID", idPhieu));

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds,"BK");

            sql2 = @"SELECT
                B.TomTatTSBS, B.TinhTrangLucVaoVien, B.CacXetNghiem
            FROM
                PhieuKhamVaDieuTriBenhNhan B
                
            WHERE
                ID = :D";

            Command = new MDB.MDBCommand(sql2, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("ID", idPhieu));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            string[] arrayTomTatTSBS = new string[1];
            string[] arrayTTLucVaoVien = new string[1];
            string[] arrayCacXetNghiem = new string[1];

            while (DataReader.Read())
            {
                arrayTomTatTSBS = JsonConvert.DeserializeObject<string[]>(DataReader["TomTatTSBS"].ToString());
                arrayTTLucVaoVien = JsonConvert.DeserializeObject<string[]>(DataReader["TinhTrangLucVaoVien"].ToString());
                arrayCacXetNghiem = JsonConvert.DeserializeObject<string[]>(DataReader["CacXetNghiem"].ToString());
                break;
            }
            DataTable BK2 = new DataTable("BK2");
            BK2.Columns.Add("TomTatTSBS");
            BK2.Columns.Add("TinhTrangLucVaoVien");
            BK2.Columns.Add("CacXetNghiem");
            BK2.Rows.Add(string.Join("\r\n", arrayTomTatTSBS), string.Join("\r\n", arrayTTLucVaoVien), string.Join("\r\n", arrayCacXetNghiem));
            
            ds.Tables.Add(BK2);
            return ds;
        }
    }
}
