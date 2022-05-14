using EMR.KyDienTu;
using System;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class BangKiemHoSoBenhAn : ThongTinKy
    {
        public BangKiemHoSoBenhAn()
        {
            TableName = "BANGKIEMHOSOBENHAN";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BKHSBA;
            TenMauPhieu = DanhMucPhieu.BKHSBA.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public int IDBangKiemHoSoBenhAn { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Ghi đầy đủ các cột mục, thông tin người bệnh đảm bảo chính xác (Họ và tên, tuổi, giới, địa chỉ, nghề nghiệp, mã số thẻ BHYT.(Có/Không)")]
        public bool Muc1 { get; set; }
        [MoTaDuLieu("Ghi rõ chẩn đoán tuyến trước (nếu có)(Có/Không)")]
        public bool Muc2 { get; set; }
        [MoTaDuLieu("Ghi rõ đặc điểm liên quan đến bệnh (tiền sử dùng thuốc, dị ứng, sử dụng rượu, thuốc lá...)")]
        public bool Muc3 { get; set; }
        [MoTaDuLieu("Ghi các thông tin mạch/ nhiệt độ/ huyết áp/ nhịp thở / chiều cao/ cân nặng")]
        public bool Muc4 { get; set; }
        [MoTaDuLieu("Xếp lệnh nhau từng lớp các kết quả xét nghiệm, huyết học, hóa sinh, vi sinh, chẩn đoán hình ảnh, giải phẫu bệnh... theo tứ tự dưới, sau trên.")]
        public bool Muc5 { get; set; }
        [MoTaDuLieu("Kết quả xét nghiệm, CĐHA... được dán đúng người bệnh.")]
        public bool Muc6 { get; set; }
        [MoTaDuLieu("Giấy cam kết của người bệnh trước khi phẫu thuật và một số thủ thuật")]
        public bool Muc7 { get; set; }
        [MoTaDuLieu("Có đầy đủ chữ kỹ và họ tên của bác sỹ, điều dưỡng, nữ hộ sinh, kỹ thuật viên...")]
        public bool Muc8 { get; set; }
        [MoTaDuLieu("Phiếu công khai thuốc phải có đầy đủ chữ ký của người bệnh/người nhà người bệnh")]
        public bool Muc9 { get; set; }
        [MoTaDuLieu("Bảng kê chi phí KCB: kê đúng, đủ tiền giường, thuốc, VTYT, DVKT...")]
        public bool Muc10 { get; set; }
        [MoTaDuLieu("Ghi rõ lý do vào viện, ngày thứ mấy hoặc giờ thứ mấy của bệnh")]
        public bool Muc11 { get; set; }
        [MoTaDuLieu("Mô tả đầy đủ các tổn thương thực thể theo hệ thống các cơ quan trong HSBA")]
        public bool Muc12 { get; set; }
        [MoTaDuLieu("Chẩn đoán đầy đủ: bệnh, nguyên nhân và mức độ biến chứng theo mã ICD 10 (ghi đúng mã bệnh theo ICD)")]
        public bool Muc13 { get; set; }
        [MoTaDuLieu("Đánh giá tình trạng bệnh và dấu hiệu sinh tốn trước khi chuyển khoa, chuyển viện")]
        public bool Muc14 { get; set; }
        [MoTaDuLieu("Chỉ viết tắt một số từ theo quy định tại văn bản số 397/YT-NV ngày 22/4/2002 của sở ý tế về việc ban hành danh mục viết tắt sử dụng trong ngày y tế BRVT")]
        public bool Muc15 { get; set; }
        [MoTaDuLieu("Làm HSBA hoàn chỉnh trước 24 giờ đối với bệnh cấp cứu, trước 36 giờ đối với các bệnh còn lại")]
        public bool Muc16 { get; set; }
        [MoTaDuLieu("Đánh số trang các tờ điều trị, dán theo thứ tự thời gian; tờ điều trị có ghi số giường, số buồng bệnh.")]
        public bool Muc17 { get; set; }
        [MoTaDuLieu("Ghi diễn biến lâm sàng của người bệnh vào HSBA")]
        public bool Muc18 { get; set; }
        [MoTaDuLieu("Tóm tắt quá trình điều trị đối với người bệnh điều trị trên 15 ngày")]
        public bool Muc19 { get; set; }
        [MoTaDuLieu("Ghi kết quả cận lâm sàng cần thiết vào HSBA")]
        public bool Muc20 { get; set; }
        [MoTaDuLieu("Khai thác tiền sử thuốc")]
        public bool Muc21 { get; set; }
        [MoTaDuLieu("Khai thác tiền sử dị ứng")]
        public bool Muc22 { get; set; }
        [MoTaDuLieu("Liệt kê các thuốc người bệnh đã dùng trước khi nhập viện trong vòng 24 giờ (nếu có, trong phần tiền sử)")]
        public bool Muc23 { get; set; }
        [MoTaDuLieu("Chỉ định thuốc: - Tên thuốc - Nồng độ / Hàm lượng -Liều dùng 1 lần -Số lần dùng thuốc trong 24 giờ    -Đường dùng thước  -Những chú ý đặc biệt khi dùng thuốc(nếu có) với thuốc không dùng, dược hết, đổi thuốc: bác sỹ ghi rõ và ký tên bênh cạnh")]
        public bool Muc24 { get; set; }
        [MoTaDuLieu("Ghi chỉ định thuốc theo thứ tự : đường tiêm, uống, đặt, dùng ngoài và các đường dùng khác.")]
        public bool Muc25 { get; set; }
        [MoTaDuLieu(" Đánh số thứ tự ngày dùng thuốc đối với một số nhóm thuốc:- Thuốc phóng xạ -Thuốc gây nghiện -Thuốc hướng tâm thần  -Thuốc kháng sinh  -Thuốc điều trị lao  -Thuốc Corticoid")]
        public bool Muc26 { get; set; }
        [MoTaDuLieu("Biên bản hội chẩn ghi đầy đủ thông tin của người bệnh, ngày giờ hội chẩn, có chữ ký trong các trường hợp phải hội chẩn:- Khó chẩn đoán và điều trị - Tiên lượng dè dặt - Cấp cứu - Chỉ định phẫu thuật - Sử dụng một số thuốc phải hội chẩn  (theo cấp quy định) - Chuyển viện")]
        public bool Muc27 { get; set; }
        [MoTaDuLieu("Họ tên trưởng khoa hành chính")]
        public string TruongKhoaHanhChinh { get; set; }
        [MoTaDuLieu("Mã trưởng khoa hành chính")]
        public string MaTruongKhoaHanhChinh { get; set; }
        [MoTaDuLieu("Họ tên bác sĩ trưởng khoa điều trị")]
        public string BSTruongKhoaDieuTri { get; set; }
        [MoTaDuLieu("Mã bác sĩ trưởng khoa điều trị")]
        public string MaBSTruongKhoaDieuTri { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
    }
    public class BangKiemHoSoBenhAnFunc
    {
        public static DataSet getDataset(MDB.MDBConnection MyConnection, decimal maQuanLy)
        {
            string sql = @"SELECT *
                                 FROM BANGKIEMHOSOBENHAN where MAQUANLY = :MAQUANLY";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", maQuanLy));
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds, "BANGKIEM");

            return ds;
        }
        public static BangKiemHoSoBenhAn getData(MDB.MDBConnection MyConnection, decimal maQuanLy)
        {
            BangKiemHoSoBenhAn bangKiemHoSoBenhAn = new BangKiemHoSoBenhAn();
            string sql = @"SELECT * FROM BANGKIEMHOSOBENHAN where MAQUANLY = :MAQUANLY";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", maQuanLy));
            Command.BindByName = true;
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            while (DataReader.Read())
            {
                bangKiemHoSoBenhAn.MaQuanLy = maQuanLy;

                int temp = 0;
                int.TryParse(DataReader["IDBangKiemHoSoBenhAn"].ToString(), out temp);
                bangKiemHoSoBenhAn.IDBangKiemHoSoBenhAn = temp;
                bangKiemHoSoBenhAn.MaBenhNhan = DataReader["MABENHNHAN"].ToString();
                bangKiemHoSoBenhAn.Muc1 = DataReader["Muc1"].ToString().Equals("1") ? true : false;
                bangKiemHoSoBenhAn.Muc2 = DataReader["Muc2"].ToString().Equals("1") ? true : false;
                bangKiemHoSoBenhAn.Muc3 = DataReader["Muc3"].ToString().Equals("1") ? true : false;
                bangKiemHoSoBenhAn.Muc4 = DataReader["Muc4"].ToString().Equals("1") ? true : false;
                bangKiemHoSoBenhAn.Muc5 = DataReader["Muc5"].ToString().Equals("1") ? true : false;
                bangKiemHoSoBenhAn.Muc6 = DataReader["Muc6"].ToString().Equals("1") ? true : false;
                bangKiemHoSoBenhAn.Muc7 = DataReader["Muc7"].ToString().Equals("1") ? true : false;
                bangKiemHoSoBenhAn.Muc8 = DataReader["Muc8"].ToString().Equals("1") ? true : false;
                bangKiemHoSoBenhAn.Muc9 = DataReader["Muc9"].ToString().Equals("1") ? true : false;
                bangKiemHoSoBenhAn.Muc10 = DataReader["Muc10"].ToString().Equals("1") ? true : false;
                bangKiemHoSoBenhAn.Muc11 = DataReader["Muc11"].ToString().Equals("1") ? true : false;
                bangKiemHoSoBenhAn.Muc12 = DataReader["Muc12"].ToString().Equals("1") ? true : false;
                bangKiemHoSoBenhAn.Muc13 = DataReader["Muc13"].ToString().Equals("1") ? true : false;
                bangKiemHoSoBenhAn.Muc14 = DataReader["Muc14"].ToString().Equals("1") ? true : false;
                bangKiemHoSoBenhAn.Muc15 = DataReader["Muc15"].ToString().Equals("1") ? true : false;
                bangKiemHoSoBenhAn.Muc16 = DataReader["Muc16"].ToString().Equals("1") ? true : false;
                bangKiemHoSoBenhAn.Muc17 = DataReader["Muc17"].ToString().Equals("1") ? true : false;
                bangKiemHoSoBenhAn.Muc18 = DataReader["Muc18"].ToString().Equals("1") ? true : false;
                bangKiemHoSoBenhAn.Muc19 = DataReader["Muc19"].ToString().Equals("1") ? true : false;
                bangKiemHoSoBenhAn.Muc20 = DataReader["Muc20"].ToString().Equals("1") ? true : false;
                bangKiemHoSoBenhAn.Muc21 = DataReader["Muc21"].ToString().Equals("1") ? true : false;
                bangKiemHoSoBenhAn.Muc22 = DataReader["Muc22"].ToString().Equals("1") ? true : false;
                bangKiemHoSoBenhAn.Muc23 = DataReader["Muc23"].ToString().Equals("1") ? true : false;
                bangKiemHoSoBenhAn.Muc24 = DataReader["Muc24"].ToString().Equals("1") ? true : false;
                bangKiemHoSoBenhAn.Muc25 = DataReader["Muc25"].ToString().Equals("1") ? true : false;
                bangKiemHoSoBenhAn.Muc26 = DataReader["Muc26"].ToString().Equals("1") ? true : false;
                bangKiemHoSoBenhAn.Muc27 = DataReader["Muc27"].ToString().Equals("1") ? true : false;
                bangKiemHoSoBenhAn.TruongKhoaHanhChinh = DataReader["TruongKhoaHanhChinh"].ToString();
                bangKiemHoSoBenhAn.MaTruongKhoaHanhChinh = DataReader["MaTruongKhoaHanhChinh"].ToString();
                bangKiemHoSoBenhAn.BSTruongKhoaDieuTri = DataReader["BSTruongKhoaDieuTri"].ToString();
                bangKiemHoSoBenhAn.MaBSTruongKhoaDieuTri = DataReader["MaBSTruongKhoaDieuTri"].ToString();
                bangKiemHoSoBenhAn.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                bangKiemHoSoBenhAn.NguoiTao = DataReader["NguoiTao"].ToString();
                bangKiemHoSoBenhAn.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                bangKiemHoSoBenhAn.NguoiSua = DataReader["NguoiSua"].ToString();
            }
            return bangKiemHoSoBenhAn;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangKiemHoSoBenhAn bangKiemHoSoBenhAn)
        {
            string sql = @"INSERT INTO BANGKIEMHOSOBENHAN
                (
                    MABENHNHAN,
                    MAQUANLY,
                    MUC1,
                    MUC2,
                    MUC3,
                    MUC4,
                    MUC5,
                    MUC6,
                    MUC7,
                    MUC8,
                    MUC9,
                    MUC10,
                    MUC11,
                    MUC12,
                    MUC13,
                    MUC14,
                    MUC15,
                    MUC16,
                    MUC17,
                    MUC18,
                    MUC19,
                    MUC20,
                    MUC21,
                    MUC22,
                    MUC23,
                    MUC24,
                    MUC25,
                    MUC26,
                    MUC27,
                    TRUONGKHOAHANHCHINH,
                    MATRUONGKHOAHANHCHINH,
                    BSTRUONGKHOADIEUTRI,
                    MABSTRUONGKHOADIEUTRI,
                    NGUOITAO,
                    NGAYTAO,
                    NGUOISUA,
                    NGAYSUA)
                VALUES
                 (	:MABENHNHAN,
                    :MAQUANLY,
                    :MUC1,
                    :MUC2,
                    :MUC3,
                    :MUC4,
                    :MUC5,
                    :MUC6,
                    :MUC7,
                    :MUC8,
                    :MUC9,
                    :MUC10,
                    :MUC11,
                    :MUC12,
                    :MUC13,
                    :MUC14,
                    :MUC15,
                    :MUC16,
                    :MUC17,
                    :MUC18,
                    :MUC19,
                    :MUC20,
                    :MUC21,
                    :MUC22,
                    :MUC23,
                    :MUC24,
                    :MUC25,
                    :MUC26,
                    :MUC27,
                    :TRUONGKHOAHANHCHINH,
                    :MATRUONGKHOAHANHCHINH,
                    :BSTRUONGKHOADIEUTRI,
                    :MABSTRUONGKHOADIEUTRI,
                    :NGUOITAO,
                    :NGAYTAO,
                    :NGUOISUA,
                    :NGAYSUA
                )  RETURNING IDBANGKIEMHOSOBENHAN INTO :IDBANGKIEMHOSOBENHAN";
            if (bangKiemHoSoBenhAn.IDBangKiemHoSoBenhAn != 0)
            {
                sql = @"UPDATE BANGKIEMHOSOBENHAN SET 
                    MABENHNHAN = :MABENHNHAN,
                    MAQUANLY = :MAQUANLY,
                    MUC1 = :MUC1,
                    MUC2 = :MUC2,
                    MUC3= :MUC3,
                    MUC4= :MUC4,
                    MUC5= :MUC5,
                    MUC6= :MUC6,
                    MUC7= :MUC7,
                    MUC8= :MUC8,
                    MUC9= :MUC9,
                    MUC10= :MUC10,
                    MUC11= :MUC11,
                    MUC12= :MUC12,
                    MUC13= :MUC13,
                    MUC14= :MUC14,
                    MUC15= :MUC15,
                    MUC16= :MUC16,
                    MUC17= :MUC17,
                    MUC18= :MUC18,
                    MUC19= :MUC19,
                    MUC20= :MUC20,
                    MUC21= :MUC21,
                    MUC22= :MUC22,
                    MUC23= :MUC23,
                    MUC24= :MUC24,
                    MUC25= :MUC25,
                    MUC26= :MUC26,
                    MUC27= :MUC27,
                    TRUONGKHOAHANHCHINH= :TRUONGKHOAHANHCHINH,
                    MATRUONGKHOAHANHCHINH= :MATRUONGKHOAHANHCHINH,
                    BSTRUONGKHOADIEUTRI= :BSTRUONGKHOADIEUTRI,
                    MABSTRUONGKHOADIEUTRI =:MABSTRUONGKHOADIEUTRI,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE IDBANGKIEMHOSOBENHAN = " + bangKiemHoSoBenhAn.IDBangKiemHoSoBenhAn;
            }
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MABENHNHAN", bangKiemHoSoBenhAn.MaBenhNhan));
            Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKiemHoSoBenhAn.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("MUC1", bangKiemHoSoBenhAn.Muc1 ? 1: 0));
            Command.Parameters.Add(new MDB.MDBParameter("MUC2", bangKiemHoSoBenhAn.Muc2 ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("MUC3", bangKiemHoSoBenhAn.Muc3 ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("MUC4", bangKiemHoSoBenhAn.Muc4 ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("MUC5", bangKiemHoSoBenhAn.Muc5 ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("MUC6", bangKiemHoSoBenhAn.Muc6 ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("MUC7", bangKiemHoSoBenhAn.Muc7 ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("MUC8", bangKiemHoSoBenhAn.Muc8 ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("MUC9", bangKiemHoSoBenhAn.Muc9 ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("MUC10", bangKiemHoSoBenhAn.Muc10 ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("MUC11", bangKiemHoSoBenhAn.Muc11 ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("MUC12", bangKiemHoSoBenhAn.Muc12 ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("MUC13", bangKiemHoSoBenhAn.Muc13 ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("MUC14", bangKiemHoSoBenhAn.Muc14 ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("MUC15", bangKiemHoSoBenhAn.Muc15 ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("MUC16", bangKiemHoSoBenhAn.Muc16 ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("MUC17", bangKiemHoSoBenhAn.Muc17 ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("MUC18", bangKiemHoSoBenhAn.Muc18 ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("MUC19", bangKiemHoSoBenhAn.Muc19 ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("MUC20", bangKiemHoSoBenhAn.Muc20 ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("MUC21", bangKiemHoSoBenhAn.Muc21 ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("MUC22", bangKiemHoSoBenhAn.Muc22 ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("MUC23", bangKiemHoSoBenhAn.Muc23 ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("MUC24", bangKiemHoSoBenhAn.Muc24 ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("MUC25", bangKiemHoSoBenhAn.Muc25 ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("MUC26", bangKiemHoSoBenhAn.Muc26 ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("MUC27", bangKiemHoSoBenhAn.Muc27 ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("TRUONGKHOAHANHCHINH", bangKiemHoSoBenhAn.TruongKhoaHanhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("MATRUONGKHOAHANHCHINH", bangKiemHoSoBenhAn.MaTruongKhoaHanhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BSTRUONGKHOADIEUTRI", bangKiemHoSoBenhAn.BSTruongKhoaDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("MABSTRUONGKHOADIEUTRI", bangKiemHoSoBenhAn.MaBSTruongKhoaDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bangKiemHoSoBenhAn.NguoiSua));
            Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bangKiemHoSoBenhAn.NgaySua));
            if (bangKiemHoSoBenhAn.IDBangKiemHoSoBenhAn == 0)
            {
                Command.Parameters.Add(new MDB.MDBParameter("IDBANGKIEMHOSOBENHAN", bangKiemHoSoBenhAn.IDBangKiemHoSoBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", bangKiemHoSoBenhAn.NguoiTao));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", bangKiemHoSoBenhAn.NgayTao));
            }

            Command.BindByName = true;
            int n = Command.ExecuteNonQuery(); // C#
            if (bangKiemHoSoBenhAn.IDBangKiemHoSoBenhAn == 0)
            {
                int nextval = Convert.ToInt32((Command.Parameters["IDBANGKIEMHOSOBENHAN"] as MDB.MDBParameter).Value);
                bangKiemHoSoBenhAn.IDBangKiemHoSoBenhAn = nextval;
            }

            return n > 0 ? true : false;
        }
    }
}
