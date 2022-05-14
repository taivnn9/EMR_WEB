
using System;
using System.Collections.Generic;
using EMR.KyDienTu;

namespace EMR_MAIN.DATABASE.Other
{
    public class XemTaiKhoanInterface
    {
        public bool? Include { get; set; } = false;
        [MoTaDuLieu("Mã định danh")]
		public long Id { get; set; }
        public string LogDate { get; set; }
        public string ThreadNm { get; set; }
        public string LogLevel { get; set; }
        public string Logger { get; set; }
        public string ExceptionNm { get; set; }
        public string UserNm { get; set; }
        public string Action { get; set; }
        public string Controller { get; set; }
        public string Duration { get; set; }
        public string Message { get; set; }
    }

    public class XemTaiKhoanStored
    {
        public static List<XemTaiKhoanInterface> GetList(string userCode, MDB.MDBConnection MyConnection)
        {
            List<XemTaiKhoanInterface> lstData = new List<XemTaiKhoanInterface>();
            try
            {
                string sql = @"select * from 
                                (select t.id,
                                       to_char(t.log_date,'dd/MM/yyyy HH24:MI:SS') log_date,
                                       t.thread_nm,
                                       t.log_level,
                                       t.logger,
                                       t.exception_nm,
                                       t.user_nm,
                                       t.action,
                                       t.controller,
                                       t.duration,
                                       t.message
                                  from LOG t
                                 where t.user_nm = :user_nm
                                 order by id desc) where rownum <= 200";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("user_nm", userCode));
                MDB.MDBDataReader reader = Command.ExecuteReader();
                while (reader.Read())
                {
                    XemTaiKhoanInterface row = new XemTaiKhoanInterface();
                    row.Id = Convert.ToInt64(reader.GetLong("ID").ToString());
                    row.LogDate = reader["log_date"].ToString();
                    row.ThreadNm = reader["thread_nm"].ToString();
                    row.LogLevel = reader["log_level"].ToString();
                    row.Logger = reader["logger"].ToString();
                    row.ExceptionNm = reader["exception_nm"].ToString();
                    row.UserNm = reader["user_nm"].ToString();
                    row.Action = reader["action"].ToString();
                    row.Controller = reader["controller"].ToString();
                    row.Duration = reader["duration"].ToString();
                    row.Message = reader["message"].ToString();
                    lstData.Add(row);
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return lstData;
        }
    }
}
