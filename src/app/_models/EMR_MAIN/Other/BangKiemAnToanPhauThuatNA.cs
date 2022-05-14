using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;


namespace EMR_MAIN.DATABASE.Other
{
    public class BangKiemAnToanPhauThuatNA : ThongTinKy
    {
        // bắt buộc tạo contructor
        public BangKiemAnToanPhauThuatNA()
        {
            TableName = "BangKiemAnToanPhauThuatNA";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BKANPTNA;
            TenMauPhieu = DanhMucPhieu.BKANPTNA.Description();
        }
        [MoTaDuLieu("Mã định danh")]
        public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
        public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ tên bệnh nhân")]
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
        public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
        public string GioiTinh { get; set; }
        [MoTaDuLieu("Dân tộc")]
        public string DanToc { get; set; }
        [MoTaDuLieu("Mã hồ sơ")]
        public string MaHoSo { get; set; }
        [MoTaDuLieu("Chẩn đoán trước mổ")]
        public string ChanDoanTruocMo { get; set; }
        [MoTaDuLieu("Phương pháp PT")]
        public string PhuongPhapPT { get; set; }
        [MoTaDuLieu("Phương pháp vô cảm")]
        public string PhuongPhapVoCam { get; set; }
        // phần tiền mê
        [MoTaDuLieu("1*. Người bệnh được xác nhận, nhận dạng vùng mổ và đồng ý phẫu thuật, 1-> Có, 2 -> không")]
        public int TienMe_1 { get; set; }
        [MoTaDuLieu("2*. Vùng mổ có được đánh dấu, 1-> có, 2-> không")]
        public int TienMe_2 { get; set; }
        [MoTaDuLieu("3. Thuốc và thiết bị gây mê được kiểm tra đầy đủ, 1-> có, 2-> không")]
        public int TienMe_3 { get; set; }
        [MoTaDuLieu("4. Máy đo độ bão hòa oxy trong máu có gắn trên NB và hoạt động bình thường, 1-> có, 2-> không")]
        public int TienMe_4 { get; set; }
        [MoTaDuLieu("5*. Đánh giá trên người bệnh. 5.1. Tiền sử dị ứng, 1-> có, 2-> không")]
        public int TienMe_51 { get; set; }
        [MoTaDuLieu("5*. Đánh giá trên người bệnh. 5.1. Tiền sử dị ứng( có, ghi rõ)")]
        public string TienMe_51_Co { get; set; }
        [MoTaDuLieu("5*. Đánh giá trên người bệnh. 5.2. khó thở, nguy cơ sặc, 1-> có, 2-> không")]
        public int TienMe_52 { get; set; }
        [MoTaDuLieu("5*. Đánh giá trên người bệnh. 5.3. Nguy cơ mất máu trên 500 ml (7ml/kg ở trẻ em), 1-> có, 2-> không")]
        public int TienMe_53 { get; set; }
        [MoTaDuLieu("Đại diện tiền mê")]
        public string TienMe_DaiDien { get; set; }
        [MoTaDuLieu("chức danh đại diện tiền mê")]
        public string TienMe_ChucDanh { get; set; }
        // phần trước khi rạch ra
        [MoTaDuLieu("Các thành viên PT, gây mê giới thiệu tên, nhiệm vụ")]
        public int CTVPTGMGTTNV { get; set; }
        [MoTaDuLieu("Xác nhận lại tên NB, phương pháp PT và vị trí rạch da")]
        public int XNLTNBPPPTVVTRD { get; set; }
        [MoTaDuLieu("1. Kháng sinh dự phòng có được thực hiện 60 phút trước gây mê không, 1-> có, 2-> không")]
        public int TruocKhiRachRa_1 { get; set; }
        [MoTaDuLieu("2. Dự kiến, 2.1. Bác sỹ phẫu thuật, 2.1.1. Những bất thường có thể xảy ra, 1-> có, 2-> không")]
        public int TruocKhiRachRa_211 { get; set; }
        [MoTaDuLieu("2. Dự kiến, 2.1. Bác sỹ phẫu thuật, 2.1.2. Thời gian cho ca phẫu thuật")]
        public string TruocKhiRachRa_212 { get; set; }
        [MoTaDuLieu("2. Dự kiến, 2.1. Bác sỹ phẫu thuật, 2.1.3. Tiên lượng mất máu, 1-> có, 2-> không")]
        public int TruocKhiRachRa_213 { get; set; }
        [MoTaDuLieu("2. Dự kiến, 2.2. Bác sỹ gây mê, các vấn đề đặc biệt về NB cần chú ý, 1-> không, 2-> có")]
        public int TruocKhiRachRa_22 { get; set; }
        [MoTaDuLieu("2. Dự kiến, 2.2. Bác sỹ gây mê, các vấn đề đặc biệt về NB cần chú ý, có ghi rõ")]
        public string TruocKhiRachRa_22_Co { get; set; }
        [MoTaDuLieu("3. BS/KTV gây mê, KTV dụng cụ, 3.1. Kiểm tra dụng cụ, phương tiện được đảm bảo vô khuẩn. 1-> có, 2-> không")]
        public int TruocKhiRachRa_31 { get; set; }
        [MoTaDuLieu("3. BS/KTV gây mê, KTV dụng cụ, 3.2. Đếm gạc, dụng cụ, kim trước khi tiến hành phẫu thuật. 1-> có, 2-> không")]
        public int TruocKhiRachRa_32 { get; set; }
        [MoTaDuLieu("3. BS/KTV gây mê, KTV dụng cụ, 3.3. Kiểm tra đảm bảo các thiết bị trước phẫu thuật hoạt động tốt. 1-> có, 2-> không")]
        public int TruocKhiRachRa_33 { get; set; }
        [MoTaDuLieu("Đại diện trước khi rạch ra")]
        public string TruocKhiRachRa_DaiDien { get; set; }
        [MoTaDuLieu("chức danh đại diện trước khi rạch ra")]
        public string TruocKhiRachRa_ChucDanh { get; set; }
        //Trước khi NB rời khỏi phòng phẫu thuật 
        [MoTaDuLieu("1. KTV dụng cụ xác định bằng miệng trước khi đóng vết mổ, 1.1 Hoàn tất việc đến kim, gạc và các dụng cụ phẫu thuật, 1 -> có, 2-> không")]
        public int RoiPhongPhauThuat_11 { get; set; }
        [MoTaDuLieu("1. KTV dụng cụ xác định bằng miệng trước khi đóng vết mổ, 1.2 Vấn đề gì về dụng cụ cần giải quyết, 1 -> có, 2-> không")]
        public int RoiPhongPhauThuat_12 { get; set; }
        [MoTaDuLieu("2. KTV thực hiện trước khi NB, 2.1 Dán nhãn bệnh phẩm ")]
        public int RoiPhongPhauThuat_21 { get; set; }
        [MoTaDuLieu("2. KTV thực hiện trước khi NB, 2.2 Đảm bảo an toàn và vô khuẩn các hệ thống dẫn lưu (nếu có)")]
        public int RoiPhongPhauThuat_22 { get; set; }
        [MoTaDuLieu("3. Bác sỹ phẫu thuật, gây mê và KTV ghi rõ")]
        public string RoiPhongPhauThuat_3 { get; set; }
        [MoTaDuLieu("Đại diện NB rời khỏi phòng phẫu thuật ")]
        public string RoiPhongPhauThuat_DaiDien { get; set; }
        [MoTaDuLieu("chức danh đại diện NB rời khỏi phòng phẫu thuật ")]
        public string RoiPhongPhauThuat_ChucDanh { get; set; }
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
    }
    public class BangKiemAnToanPhauThuatNAFunc
    {
        public const string TableName = "BangKiemAnToanPhauThuatNA";
        public const string TablePrimaryKeyName = "ID";
        public static List<BangKiemAnToanPhauThuatNA> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangKiemAnToanPhauThuatNA> list = new List<BangKiemAnToanPhauThuatNA>();
            try
            {
                string sql = @"SELECT * FROM BangKiemAnToanPhauThuatNA where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangKiemAnToanPhauThuatNA data = new BangKiemAnToanPhauThuatNA();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.DanToc = XemBenhAn._HanhChinhBenhNhan.DanToc;
                    data.MaHoSo = DataReader["MaHoSo"].ToString();
                    data.ChanDoanTruocMo = DataReader["ChanDoanTruocMo"].ToString();
                    data.PhuongPhapPT = DataReader["PhuongPhapPT"].ToString();
                    data.PhuongPhapVoCam = DataReader["PhuongPhapVoCam"].ToString();
                    data.TienMe_1 = DataReader.GetInt("TienMe_1");
                    data.TienMe_2 = DataReader.GetInt("TienMe_2");
                    data.TienMe_3 = DataReader.GetInt("TienMe_3");
                    data.TienMe_4 = DataReader.GetInt("TienMe_4");
                    data.TienMe_51 = DataReader.GetInt("TienMe_51");
                    data.TienMe_51_Co = DataReader["TienMe_51_Co"].ToString();
                    data.TienMe_52 = DataReader.GetInt("TienMe_52");
                    data.TienMe_53 = DataReader.GetInt("TienMe_53");
                    data.TienMe_DaiDien = DataReader["TienMe_DaiDien"].ToString();
                    data.TienMe_ChucDanh = DataReader["TienMe_ChucDanh"].ToString();
                    data.CTVPTGMGTTNV = DataReader.GetInt("CTVPTGMGTTNV");
                    data.XNLTNBPPPTVVTRD = DataReader.GetInt("XNLTNBPPPTVVTRD");
                    data.TruocKhiRachRa_1 = DataReader.GetInt("TruocKhiRachRa_1");
                    data.TruocKhiRachRa_211 = DataReader.GetInt("TruocKhiRachRa_211");
                    data.TruocKhiRachRa_212 = DataReader["TruocKhiRachRa_212"].ToString();
                    data.TruocKhiRachRa_213 = DataReader.GetInt("TruocKhiRachRa_213");
                    data.TruocKhiRachRa_22 = DataReader.GetInt("TruocKhiRachRa_22");
                    data.TruocKhiRachRa_22_Co = DataReader["TruocKhiRachRa_22_Co"].ToString();
                    data.TruocKhiRachRa_31 = DataReader.GetInt("TruocKhiRachRa_31");
                    data.TruocKhiRachRa_32 = DataReader.GetInt("TruocKhiRachRa_32");
                    data.TruocKhiRachRa_33 = DataReader.GetInt("TruocKhiRachRa_33");
                    data.TruocKhiRachRa_DaiDien = DataReader["TruocKhiRachRa_DaiDien"].ToString();
                    data.TruocKhiRachRa_ChucDanh = DataReader["TruocKhiRachRa_ChucDanh"].ToString();
                    data.RoiPhongPhauThuat_11 = DataReader.GetInt("RoiPhongPhauThuat_11");
                    data.RoiPhongPhauThuat_12 = DataReader.GetInt("RoiPhongPhauThuat_12");
                    data.RoiPhongPhauThuat_21 = DataReader.GetInt("RoiPhongPhauThuat_21");
                    data.RoiPhongPhauThuat_22 = DataReader.GetInt("RoiPhongPhauThuat_22");
                    data.RoiPhongPhauThuat_3 = DataReader["RoiPhongPhauThuat_3"].ToString();
                    data.RoiPhongPhauThuat_DaiDien = DataReader["RoiPhongPhauThuat_DaiDien"].ToString();
                    data.RoiPhongPhauThuat_ChucDanh = DataReader["RoiPhongPhauThuat_ChucDanh"].ToString();


                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangKiemAnToanPhauThuatNA ketQua)
        {
            try
            {
                string sql = @"INSERT INTO BangKiemAnToanPhauThuatNA
                (
                    MAQUANLY,
                    MaBenhNhan,
                    MaHoSo,
                    ChanDoanTruocMo,
                    PhuongPhapPT,
                    PhuongPhapVoCam,
                    TienMe_1,
                    TienMe_2,
                    TienMe_3,
                    TienMe_4,
                    TienMe_51,
                    TienMe_51_Co,
                    TienMe_52,
                    TienMe_53,
                    TienMe_DaiDien,
                    TienMe_ChucDanh,
                    CTVPTGMGTTNV,
                    XNLTNBPPPTVVTRD,
                    TruocKhiRachRa_1,
                    TruocKhiRachRa_211,
                    TruocKhiRachRa_212,
                    TruocKhiRachRa_213,
                    TruocKhiRachRa_22,
                    TruocKhiRachRa_22_Co,
                    TruocKhiRachRa_31,
                    TruocKhiRachRa_32,
                    TruocKhiRachRa_33,
                    TruocKhiRachRa_DaiDien,
                    TruocKhiRachRa_ChucDanh,
                    RoiPhongPhauThuat_11,
                    RoiPhongPhauThuat_12,
                    RoiPhongPhauThuat_21,
                    RoiPhongPhauThuat_22,
                    RoiPhongPhauThuat_3,
                    RoiPhongPhauThuat_DaiDien,
                    RoiPhongPhauThuat_ChucDanh,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :MaHoSo,
                    :ChanDoanTruocMo,
                    :PhuongPhapPT,
                    :PhuongPhapVoCam,
                    :TienMe_1,
                    :TienMe_2,
                    :TienMe_3,
                    :TienMe_4,
                    :TienMe_51,
                    :TienMe_51_Co,
                    :TienMe_52,
                    :TienMe_53,
                    :TienMe_DaiDien,
                    :TienMe_ChucDanh,
                    :CTVPTGMGTTNV,
                    :XNLTNBPPPTVVTRD,
                    :TruocKhiRachRa_1,
                    :TruocKhiRachRa_211,
                    :TruocKhiRachRa_212,
                    :TruocKhiRachRa_213,
                    :TruocKhiRachRa_22,
                    :TruocKhiRachRa_22_Co,
                    :TruocKhiRachRa_31,
                    :TruocKhiRachRa_32,
                    :TruocKhiRachRa_33,
                    :TruocKhiRachRa_DaiDien,
                    :TruocKhiRachRa_ChucDanh,
                    :RoiPhongPhauThuat_11,
                    :RoiPhongPhauThuat_12,
                    :RoiPhongPhauThuat_21,
                    :RoiPhongPhauThuat_22,
                    :RoiPhongPhauThuat_3,
                    :RoiPhongPhauThuat_DaiDien,
                    :RoiPhongPhauThuat_ChucDanh,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE BangKiemAnToanPhauThuatNA SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    MaHoSo = :MaHoSo,
                    ChanDoanTruocMo=:ChanDoanTruocMo,
                    PhuongPhapPT=:PhuongPhapPT,
                    PhuongPhapVoCam=:PhuongPhapVoCam,
                    TienMe_1=:TienMe_1,
                    TienMe_2=:TienMe_2,
                    TienMe_3=:TienMe_3,
                    TienMe_4=:TienMe_4,
                    TienMe_51=:TienMe_51,
                    TienMe_51_Co=:TienMe_51_Co,
                    TienMe_52=:TienMe_52,
                    TienMe_53=:TienMe_53,
                    TienMe_DaiDien=:TienMe_DaiDien,
                    TienMe_ChucDanh=:TienMe_ChucDanh,
                    CTVPTGMGTTNV=:CTVPTGMGTTNV,
                    XNLTNBPPPTVVTRD=:XNLTNBPPPTVVTRD,
                    TruocKhiRachRa_1=:TruocKhiRachRa_1,
                    TruocKhiRachRa_211=:TruocKhiRachRa_211,
                    TruocKhiRachRa_212=:TruocKhiRachRa_212,
                    TruocKhiRachRa_213=:TruocKhiRachRa_213,
                    TruocKhiRachRa_22=:TruocKhiRachRa_22,
                    TruocKhiRachRa_22_Co=:TruocKhiRachRa_22_Co,
                    TruocKhiRachRa_31=:TruocKhiRachRa_31,
                    TruocKhiRachRa_32=:TruocKhiRachRa_32,
                    TruocKhiRachRa_33=:TruocKhiRachRa_33,
                    TruocKhiRachRa_DaiDien=:TruocKhiRachRa_DaiDien,
                    TruocKhiRachRa_ChucDanh=:TruocKhiRachRa_ChucDanh,
                    RoiPhongPhauThuat_11=:RoiPhongPhauThuat_11,
                    RoiPhongPhauThuat_12=:RoiPhongPhauThuat_12,
                    RoiPhongPhauThuat_21=:RoiPhongPhauThuat_21,
                    RoiPhongPhauThuat_22=:RoiPhongPhauThuat_22,
                    RoiPhongPhauThuat_3=:RoiPhongPhauThuat_3,
                    RoiPhongPhauThuat_DaiDien=:RoiPhongPhauThuat_DaiDien,
                    RoiPhongPhauThuat_ChucDanh=:RoiPhongPhauThuat_ChucDanh,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("MaHoSo", ketQua.MaHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTruocMo", ketQua.ChanDoanTruocMo));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapPT", ketQua.PhuongPhapPT));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapVoCam", ketQua.PhuongPhapVoCam));
                Command.Parameters.Add(new MDB.MDBParameter("TienMe_1", ketQua.TienMe_1));
                Command.Parameters.Add(new MDB.MDBParameter("TienMe_2", ketQua.TienMe_2));
                Command.Parameters.Add(new MDB.MDBParameter("TienMe_3", ketQua.TienMe_3));
                Command.Parameters.Add(new MDB.MDBParameter("TienMe_4", ketQua.TienMe_4));
                Command.Parameters.Add(new MDB.MDBParameter("TienMe_51", ketQua.TienMe_51));
                Command.Parameters.Add(new MDB.MDBParameter("TienMe_51_Co", ketQua.TienMe_51_Co));
                Command.Parameters.Add(new MDB.MDBParameter("TienMe_52", ketQua.TienMe_52));
                Command.Parameters.Add(new MDB.MDBParameter("TienMe_53", ketQua.TienMe_53));
                Command.Parameters.Add(new MDB.MDBParameter("TienMe_DaiDien", ketQua.TienMe_DaiDien));
                Command.Parameters.Add(new MDB.MDBParameter("TienMe_ChucDanh", ketQua.TienMe_ChucDanh));
                Command.Parameters.Add(new MDB.MDBParameter("CTVPTGMGTTNV", ketQua.CTVPTGMGTTNV));
                Command.Parameters.Add(new MDB.MDBParameter("XNLTNBPPPTVVTRD", ketQua.XNLTNBPPPTVVTRD));
                Command.Parameters.Add(new MDB.MDBParameter("TruocKhiRachRa_1", ketQua.TruocKhiRachRa_1));
                Command.Parameters.Add(new MDB.MDBParameter("TruocKhiRachRa_211", ketQua.TruocKhiRachRa_211));
                Command.Parameters.Add(new MDB.MDBParameter("TruocKhiRachRa_212", ketQua.TruocKhiRachRa_212));
                Command.Parameters.Add(new MDB.MDBParameter("TruocKhiRachRa_213", ketQua.TruocKhiRachRa_213));
                Command.Parameters.Add(new MDB.MDBParameter("TruocKhiRachRa_22", ketQua.TruocKhiRachRa_22));
                Command.Parameters.Add(new MDB.MDBParameter("TruocKhiRachRa_22_Co", ketQua.TruocKhiRachRa_22_Co));
                Command.Parameters.Add(new MDB.MDBParameter("TruocKhiRachRa_31", ketQua.TruocKhiRachRa_31));
                Command.Parameters.Add(new MDB.MDBParameter("TruocKhiRachRa_32", ketQua.TruocKhiRachRa_32));
                Command.Parameters.Add(new MDB.MDBParameter("TruocKhiRachRa_33", ketQua.TruocKhiRachRa_33));
                Command.Parameters.Add(new MDB.MDBParameter("TruocKhiRachRa_DaiDien", ketQua.TruocKhiRachRa_DaiDien));
                Command.Parameters.Add(new MDB.MDBParameter("TruocKhiRachRa_ChucDanh", ketQua.TruocKhiRachRa_ChucDanh));
                Command.Parameters.Add(new MDB.MDBParameter("RoiPhongPhauThuat_11", ketQua.RoiPhongPhauThuat_11));
                Command.Parameters.Add(new MDB.MDBParameter("RoiPhongPhauThuat_12", ketQua.RoiPhongPhauThuat_12));
                Command.Parameters.Add(new MDB.MDBParameter("RoiPhongPhauThuat_21", ketQua.RoiPhongPhauThuat_21));
                Command.Parameters.Add(new MDB.MDBParameter("RoiPhongPhauThuat_22", ketQua.RoiPhongPhauThuat_22));
                Command.Parameters.Add(new MDB.MDBParameter("RoiPhongPhauThuat_3", ketQua.RoiPhongPhauThuat_3));
                Command.Parameters.Add(new MDB.MDBParameter("RoiPhongPhauThuat_DaiDien", ketQua.RoiPhongPhauThuat_DaiDien));
                Command.Parameters.Add(new MDB.MDBParameter("RoiPhongPhauThuat_ChucDanh", ketQua.RoiPhongPhauThuat_ChucDanh));

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
        public static bool delete(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM BangKiemAnToanPhauThuatNA WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("ID", id));
                command.BindByName = true;
                int n = command.ExecuteNonQuery();
                return n > 0 ? true : false;
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
                P.*, f.hovaten TienMe_DaiDienHT, g.hovaten TruocKhiRachRa_DaiDienHT, h.hovaten RoiPhongPhauThuat_DaiDienHT
            FROM
                BangKiemAnToanPhauThuatNA P
            left join nhanvien f on P.TienMe_DaiDien = f.manhanvien
            left join nhanvien g on P.TruocKhiRachRa_DaiDien = g.manhanvien
            left join nhanvien h on P.RoiPhongPhauThuat_DaiDien = h.manhanvien 
            WHERE
                P.ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "BK");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("NamSinh", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(int));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));
            ds.Tables[0].AddColumn("KHOA", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["NamSinh"] = XemBenhAn._HanhChinhBenhNhan.NgaySinh.HasValue ? XemBenhAn._HanhChinhBenhNhan.NgaySinh.Value.Year + "" : "";
            ds.Tables[0].Rows[0]["GioiTinh"] = (int)XemBenhAn._HanhChinhBenhNhan.GioiTinh;
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["KHOA"] = XemBenhAn._ThongTinDieuTri.Khoa;

            return ds;
        }
    }
}
