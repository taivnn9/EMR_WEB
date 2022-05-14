
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMR.KyDienTu;

namespace EMR_MAIN.DATABASE.Other
{
    public class Log_DoiBenhAn
    {
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã định danh bệnh án cũ")]
		public int IDBenhAnCu { get; set; }
        public string BenhAnCu { get; set; }
        [MoTaDuLieu("Mã định danh bệnh án mới")]
		public int IDBenhAnMoi { get; set; }
        public DateTime ThoiGiam { get; set; }
        [MoTaDuLieu("Mã nhân viên")]
		public string MaNhanVien { get; set; }
    }
    public class Log_DoiBenhAnFunc
    {
        public static bool Insert(Log_DoiBenhAn log_DoiBenhAn, MDB.MDBConnection conn)
        {
            try
            {
                string sql = "INSERT INTO LOG_DOIBENHAN (MAQUANLY, IDBENHANCU, IDBENHANMOI, MANHANVIEN, BENHANCU) VALUES (:MAQUANLY, :IDBENHANCU, :IDBENHANMOI, :MANHANVIEN, :BENHANCU)";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, conn);
                command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", log_DoiBenhAn.MaQuanLy));
                command.Parameters.Add(new MDB.MDBParameter("IDBENHANCU", log_DoiBenhAn.IDBenhAnCu));
                command.Parameters.Add(new MDB.MDBParameter("IDBENHANMOI", log_DoiBenhAn.IDBenhAnMoi));
                command.Parameters.Add(new MDB.MDBParameter("MANHANVIEN", log_DoiBenhAn.MaNhanVien));
                command.Parameters.Add(new MDB.MDBParameter("BENHANCU", log_DoiBenhAn.BenhAnCu));

                int executeNonQuery = command.ExecuteNonQuery();
                return executeNonQuery > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
    }
}
