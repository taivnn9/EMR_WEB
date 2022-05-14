using PMS.Access;
using System;
using System.Collections.Generic;
using static EMR_MAIN.DATABASE.Other.MauMaHoaChamSocFunc;
using EMR.KyDienTu;

namespace EMR_MAIN.DATABASE.Other
{
    public class MauMaHoaChamSoc
    {
        public MauMaHoaChamSoc()
        {
            DANHMUC = new List<MaHoaChamSoc>();
        }
        public long MAUMAHOA_ID { get; set; }
        public bool? INCLUDE { get; set; }
        public string MAUMAHOA_CODE { get; set; }
        public string TENMAUMAHOA { get; set; }
        public string NGUOITAO { get; set; }
        public string NGUOISUA { get; set; }
        public DateTime THOIGIANTAO { get; set; }
        public DateTime? THOIGIANSUA { get; set; }
        public string MAKHOA { get; set; }
        public List<MaHoaChamSoc> DANHMUC { get; set; }//không dùng cột nội dung, do khoa phòng mạnh ai lấy khai ở phiên bản cũ, bị đè mất dữ liệu mới khai
        public List<MaHoaChamSoc> NOIDUNG { get; set; }//không dùng cột nội dung, do khoa phòng mạnh ai lấy khai ở phiên bản cũ, bị đè mất 
    }

    public class MauMaHoaChamSocFunc
    {
        public static bool InsertOrUpdate(MauMaHoaChamSoc mauMaHoa, MDB.MDBConnection conn)
        {
            try
            {
                if (string.IsNullOrEmpty(mauMaHoa.MAKHOA))
                {
                    return false;
                }
                string sql = "SELECT MAKHOA FROM MAUMAHOACHAMSOC WHERE MAKHOA = :MAKHOA";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, conn);
                command.Parameters.Add(new MDB.MDBParameter("MAKHOA", mauMaHoa.MAKHOA));
                MDB.MDBDataReader dataReader = command.ExecuteReader();
                int iCount = 0;
                while (dataReader.Read()) iCount++;
                if (iCount > 0)
                {
                    sql = "UPDATE MAUMAHOACHAMSOC SET MAUMAHOA_CODE = :MAUMAHOA_CODE, TENMAUMAHOA = :TENMAUMAHOA, DANHMUC = :DANHMUC, NGUOITAO = :NGUOITAO, NGUOISUA = :NGUOISUA, THOIGIANTAO = :THOIGIANTAO, THOIGIANSUA = :THOIGIANSUA"
                        + " WHERE MAKHOA = :MAKHOA";
                }
                else
                {
                    sql = "INSERT INTO MAUMAHOACHAMSOC (MAUMAHOA_ID, MAUMAHOA_CODE, TENMAUMAHOA, DANHMUC, NGUOITAO, NGUOISUA, THOIGIANTAO, THOIGIANSUA, MAKHOA) VALUES (:MAUMAHOA_ID, :MAUMAHOA_CODE, :TENMAUMAHOA, :DANHMUC, :NGUOITAO, :NGUOISUA, :THOIGIANTAO, :THOIGIANSUA, :MAKHOA)";
                }
                command = new MDB.MDBCommand(sql, conn);
                if (iCount == 0)
                {
                    command.Parameters.Add(new MDB.MDBParameter("MAUMAHOA_ID", 1 + GetLatestID(conn)));
                }
                command.Parameters.Add(new MDB.MDBParameter("MAUMAHOA_CODE", mauMaHoa.MAUMAHOA_CODE));
                command.Parameters.Add(new MDB.MDBParameter("TENMAUMAHOA", mauMaHoa.TENMAUMAHOA));
                command.Parameters.Add(new MDB.MDBParameter("DANHMUC", Newtonsoft.Json.JsonConvert.SerializeObject(mauMaHoa.DANHMUC == null ? new List<MaHoaChamSoc>() : mauMaHoa.DANHMUC)));
                if (iCount == 0)
                    command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", Common.getUserLogin()));
                else
                    command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", mauMaHoa.NGUOITAO));
                if (iCount > 0)
                    command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", Common.getUserLogin()));
                else
                    command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", mauMaHoa.NGUOISUA));
                if (iCount == 0)
                    command.Parameters.Add(new MDB.MDBParameter("THOIGIANTAO", DateTime.Now));
                else
                    command.Parameters.Add(new MDB.MDBParameter("THOIGIANTAO", mauMaHoa.THOIGIANTAO));
                if (iCount > 0)
                    command.Parameters.Add(new MDB.MDBParameter("THOIGIANSUA", DateTime.Now));
                else
                    command.Parameters.Add(new MDB.MDBParameter("THOIGIANSUA", null));
                command.Parameters.Add(new MDB.MDBParameter("MAKHOA", mauMaHoa.MAKHOA));
                int n = command.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static long GetLatestID(MDB.MDBConnection conn)
        {
            int latestID = 1;
            try
            {
                string sql = string.Format("SELECT * FROM ({0}) WHERE ROWNUM = 1",
                    "SELECT MAUMAHOA_ID FROM MauMaHoaChamSoc ORDER BY MAUMAHOA_ID DESC");
                MDB.MDBCommand cmd = new MDB.MDBCommand(sql, conn);
                var rs = cmd.ExecuteScalar();
                latestID = Convert.ToInt32(rs);
            }
            catch { }
            return latestID;
        }
        public static bool Delete(string MAKHOA, MDB.MDBConnection conn)
        {
            try
            {
                string sSql = "DELETE FROM MauMaHoaChamSoc WHERE MAKHOA = :MAKHOA";
                MDB.MDBCommand command = new MDB.MDBCommand(sSql, conn);
                command.Parameters.Add(new MDB.MDBParameter("MAKHOA", MAKHOA));
                int n = command.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static MauMaHoaChamSoc GetMauMaHoaChamSoc(MDB.MDBConnection conn, string MAKHOA)
        {
            MauMaHoaChamSoc mauMaHoaChamSoc = new MauMaHoaChamSoc();
            try
            {
                string sql = "SELECT MAKHOA, MAUMAHOA_CODE, TENMAUMAHOA, DANHMUC, NGUOITAO, NGUOISUA, THOIGIANTAO, THOIGIANSUA FROM MAUMAHOACHAMSOC WHERE MAKHOA = :MAKHOA";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, conn);
                command.Parameters.Add(new MDB.MDBParameter("MAKHOA", MAKHOA));
                MDB.MDBDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    mauMaHoaChamSoc.MAKHOA = dataReader["MAKHOA"] == null ? null : dataReader["MAKHOA"].ToString();
                    mauMaHoaChamSoc.MAUMAHOA_CODE = dataReader["MAUMAHOA_CODE"] == null ? null : dataReader["MAUMAHOA_CODE"].ToString();
                    mauMaHoaChamSoc.TENMAUMAHOA = dataReader["TENMAUMAHOA"] == null ? null : dataReader["TENMAUMAHOA"].ToString();
                    mauMaHoaChamSoc.DANHMUC = dataReader["DANHMUC"] == null ? new List<MaHoaChamSoc>() : Newtonsoft.Json.JsonConvert.DeserializeObject<List<MaHoaChamSoc>>(dataReader["DANHMUC"].ToString());
                    mauMaHoaChamSoc.NGUOITAO = dataReader["NGUOITAO"] == null ? null : dataReader["NGUOITAO"].ToString();
                    mauMaHoaChamSoc.NGUOISUA = dataReader["NGUOISUA"] == null ? null : dataReader["NGUOISUA"].ToString();
                    mauMaHoaChamSoc.NOIDUNG = mauMaHoaChamSoc.DANHMUC;
                    try
                    {
                        mauMaHoaChamSoc.THOIGIANTAO = dataReader["THOIGIANTAO"].IsNullOrEmpty() ? DateTime.Now : dataReader.GetDate("THOIGIANTAO");
                    }
                    catch { }
                    try
                    {
                        mauMaHoaChamSoc.THOIGIANSUA = dataReader["THOIGIANSUA"].IsNullOrEmpty() ? (DateTime?)null : dataReader.GetDate("THOIGIANSUA");
                    }
                    catch { }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return mauMaHoaChamSoc;
        }

        public List<MaHoaChamSoc> GetMaHoaChamSoc(MDB.MDBConnection MyConnection, string MaKhoa_DsMaHoa)
        {
            var mauMaHoaChamSoc = MauMaHoaChamSocFunc.GetMauMaHoaChamSoc(MyConnection, MaKhoa_DsMaHoa);
            if (mauMaHoaChamSoc != null)
            {
                if (mauMaHoaChamSoc.DANHMUC != null && mauMaHoaChamSoc.DANHMUC.Count > 0)
                {
                    foreach (var r in mauMaHoaChamSoc.DANHMUC)
                    {
                        r.NOIDUNG = r.DANHMUC;
                    }
                    return mauMaHoaChamSoc.DANHMUC;
                }
            }

            List<MaHoaChamSoc> _lstMaHoa = new List<MaHoaChamSoc>();
            _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C1: HD nội quy, quyền lợi, nghĩa vụ NB" });
            _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C2: Lấy bệnh phẩm xét nghiệm" });
            _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C3: Đưa NB đi làm CLS" });
            _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C4: Ghi điện tâm đồ" });
            _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C5: Thực hiện y lệnh thuốc" });
            _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C6: Thực hiện y lệnh thuốc bổ sung" });
            _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C7: HD chế độ ăn theo y lệnh" });
            _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C8: Thực hiện chế độ ăn" });
            _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C9: Cho NB ăn qua sonde" });
            _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C10: Hướng dẫn vệ sinh cá nhân" });
            _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C11: Thực hiện vệ sinh răng miệng" });
            _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C12: Thực hiện tắm" });
            _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C13: Thực hiện gội đầu" });
            _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C14: Đặt sonde dạ dày" });
            _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C15: Rút sonde dạ dày" });
            _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C16: Phụ giúp bác sỹ làm thủ thuật" });
            _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C17: Thay băng" });
            _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C18: Cắt chỉ" });
            _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C19: Rút sonde dẫn lưu" });
            _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C20: Thông tiểu" });
            _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C21: Dẫn lưu nước tiểu" });
            _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C22: Bơm rửa bàng quang" });
            _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C23: Rút sonde bàng quang" });
            _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C24: Cho NB thở oxy" });
            _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C25: Dừng thở oxy cho NB" });
            _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C26: TV, GDSK về dinh dưỡng" });
            _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C27: TV, GDSK về nghỉ ngơi, vận động" });
            _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C28: TV, GDSK về sử dụng thuốc" });
            _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C29: Giáo dục sức khỏe" });
            _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C30: Hướng dẫn các thủ tục ra viện" });
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.SanKhoa)
            {
                _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C31: Đặt monitor theo dõi NB" });
                _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C32: Thụt tháo" });
                _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C33: Đỡ đẻ" });
                _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C34: Làm thuốc âm đạo" });
                _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C35: Vệ sinh tầng sinh môn" });
                _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C36: Tư vấn nuôi con bằng sữa mẹ" });
            }
            else
            {
                _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C31:" });
                _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C32:" });
                _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C33:" });
                _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C34:" });
                _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C35:" });
                _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C36:" });
            }
            _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C37:" });
            _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C38:" });
            _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C39:" });
            _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C40:" });
            _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C41:" });
            _lstMaHoa.Add(new MaHoaChamSoc() { DANHMUC = "C42:" });
            foreach (var r in _lstMaHoa)
            {
                r.NOIDUNG = r.DANHMUC;
            }
            return _lstMaHoa;
        }

        public class MaHoaChamSoc
        {
            [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
            public string DANHMUC { get; set; }
            public string NOIDUNG { get; set; }
            public int STT { get; set; }
        }

        public static IList<MauMaHoaChamSoc> GetMauMaHoaChamSoc(MDB.MDBConnection conn)
        {
            IList<MauMaHoaChamSoc> mauMaHoaChamSocs = new List<MauMaHoaChamSoc>();
            try
            {
                string sql = "SELECT MAKHOA, MAUMAHOA_CODE, TENMAUMAHOA, DANHMUC, NGUOITAO, NGUOISUA, THOIGIANTAO, THOIGIANSUA FROM MAUMAHOACHAMSOC";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, conn);
                MDB.MDBDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    MauMaHoaChamSoc mauMaHoaChamSoc = new MauMaHoaChamSoc();
                    mauMaHoaChamSoc.MAKHOA = dataReader["MAKHOA"] == null ? null : dataReader["MAKHOA"].ToString();
                    mauMaHoaChamSoc.MAUMAHOA_CODE = dataReader["MAUMAHOA_CODE"] == null ? null : dataReader["MAUMAHOA_CODE"].ToString();
                    mauMaHoaChamSoc.TENMAUMAHOA = dataReader["TENMAUMAHOA"] == null ? null : dataReader["TENMAUMAHOA"].ToString();
                    mauMaHoaChamSoc.DANHMUC = dataReader["DANHMUC"] == null ? new List<MaHoaChamSoc>() : Newtonsoft.Json.JsonConvert.DeserializeObject<List<MaHoaChamSoc>>(dataReader["DANHMUC"].ToString());
                    mauMaHoaChamSoc.NGUOITAO = dataReader["NGUOITAO"] == null ? null : dataReader["NGUOITAO"].ToString();
                    mauMaHoaChamSoc.NGUOISUA = dataReader["NGUOISUA"] == null ? null : dataReader["NGUOISUA"].ToString();
                    mauMaHoaChamSoc.THOIGIANTAO = Convert.ToDateTime(dataReader["THOIGIANTAO"] == DBNull.Value ? DateTime.Now : dataReader.GetDate("THOIGIANTAO"));
                    mauMaHoaChamSoc.THOIGIANSUA = Convert.ToDateTime(dataReader["THOIGIANSUA"] == DBNull.Value ? DateTime.Now : dataReader.GetDate("THOIGIANSUA"));
                    mauMaHoaChamSocs.Add(mauMaHoaChamSoc);
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return mauMaHoaChamSocs;
        }
    }
}