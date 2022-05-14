using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using EMR.KyDienTu;

namespace EMR_MAIN.DATABASE.Other
{
    public class MauMaHoaDichTruyen
    {
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        public string Username { get; set; }
        public List<MaHoaDichTruyen> DSMaHoaDichTruyen { get; set; }

        public MauMaHoaDichTruyen()
        {
            this.DSMaHoaDichTruyen = new List<MaHoaDichTruyen>()
                {
                    new DATABASE.Other.MaHoaDichTruyen(){MaDichTruyen = "D1", TenDichTruyen = "Natriclorid 9‰"},
                    new DATABASE.Other.MaHoaDichTruyen(){MaDichTruyen = "D2", TenDichTruyen = "Ringer lactat"},
                    new DATABASE.Other.MaHoaDichTruyen(){MaDichTruyen = "D3", TenDichTruyen = "Glucose 5%"},
                    new DATABASE.Other.MaHoaDichTruyen(){MaDichTruyen = "D4", TenDichTruyen = "Glucose 20%"},
                    new DATABASE.Other.MaHoaDichTruyen(){MaDichTruyen = "D5", TenDichTruyen = "Natribicarbonat 14‰"},
                    new DATABASE.Other.MaHoaDichTruyen(){MaDichTruyen = "D6", TenDichTruyen = "Manitol 20%"},
                    new DATABASE.Other.MaHoaDichTruyen(){MaDichTruyen = "D7", TenDichTruyen = "Heas-steril 6%"},
                    new DATABASE.Other.MaHoaDichTruyen(){MaDichTruyen = "D8", TenDichTruyen = "Amigold 8,5%"},
                    new DATABASE.Other.MaHoaDichTruyen(){MaDichTruyen = "D9", TenDichTruyen = ""},
                    new DATABASE.Other.MaHoaDichTruyen(){MaDichTruyen = "D10", TenDichTruyen = ""}
                };
        }
    }

    public class MauMaHoaDichTruyenFunc
    {
        public static bool InsertOrUpdate(MDB.MDBConnection conn, MauMaHoaDichTruyen data)
        {
            try
            {
                string sql = "SELECT * FROM MAUMAHOADICHTRUYEN WHERE MAKHOA = :MAKHOA";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, conn);
                command.Parameters.Add(new MDB.MDBParameter("MAKHOA", data.MaKhoa));
                MDB.MDBDataReader dataReader = command.ExecuteReader();
                int count = 0;
                while (dataReader.Read()) count++;
                if (count > 0)
                {
                    sql = "UPDATE MAUMAHOADICHTRUYEN SET USERNAME = :USERNAME, DSMAHOADICHTRUYEN = :DSMAHOADICHTRUYEN WHERE MAKHOA = :MAKHOA";
                    command = new MDB.MDBCommand(sql, conn);
                    command.Parameters.Add(new MDB.MDBParameter("USERNAME", data.Username));
                    command.Parameters.Add(new MDB.MDBParameter("DSMAHOADICHTRUYEN", JsonConvert.SerializeObject(data.DSMaHoaDichTruyen)));
                    command.Parameters.Add(new MDB.MDBParameter("MAKHOA", data.MaKhoa));
                }
                else
                {
                    sql = "INSERT INTO MAUMAHOADICHTRUYEN (MAKHOA, USERNAME, DSMAHOADICHTRUYEN) VALUES (:MAKHOA, :USERNAME, :DSMAHOADICHTRUYEN)";
                    command = new MDB.MDBCommand(sql, conn);
                    command.Parameters.Add(new MDB.MDBParameter("MAKHOA", data.MaKhoa));
                    command.Parameters.Add(new MDB.MDBParameter("USERNAME", data.Username));
                    command.Parameters.Add(new MDB.MDBParameter("DSMAHOADICHTRUYEN", JsonConvert.SerializeObject(data.DSMaHoaDichTruyen)));
                }
                int rs = command.ExecuteNonQuery();
                return rs > 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool Delete(MDB.MDBConnection conn, string MaKhoa)
        {
            try
            {
                string sSql = "DELETE FROM MAUMAHOADICHTRUYEN WHERE MAKHOA = :MAKHOA";
                MDB.MDBCommand command = new MDB.MDBCommand(sSql, conn);
                command.Parameters.Add(new MDB.MDBParameter("MAKHOA", MaKhoa));
                int n = command.ExecuteNonQuery();
                return n > 0;
            }

            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }

        public static MauMaHoaDichTruyen Get(MDB.MDBConnection conn, string MaKhoa)
        {
            MauMaHoaDichTruyen data = new MauMaHoaDichTruyen();
            try
            {
                string sql = "SELECT * FROM MAUMAHOADICHTRUYEN WHERE MAKHOA = :MAKHOA";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, conn);
                command.Parameters.Add(new MDB.MDBParameter("MAKHOA", MaKhoa));
                MDB.MDBDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    data.MaKhoa = dataReader["MAKHOA"].ToString();
                    data.Username = dataReader["USERNAME"].ToString();
                    try
                    {
                        data.DSMaHoaDichTruyen = JsonConvert.DeserializeObject<List<MaHoaDichTruyen>>(dataReader["DSMAHOADICHTRUYEN"].ToString());
                    }
                    catch { }
                    //catch { data.DSMaHoaDichTruyen = new List<MaHoaDichTruyen>(); }
                    break;
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            //if (data.DSMaHoaDichTruyen == null || data.DSMaHoaDichTruyen.Count == 0)
            //{
            //    data.DSMaHoaDichTruyen = new List<MaHoaDichTruyen>()
            //    {
            //        new DATABASE.Other.MaHoaDichTruyen(){MaDichTruyen = "D1", TenDichTruyen = "Natriclorid 9‰"},
            //        new DATABASE.Other.MaHoaDichTruyen(){MaDichTruyen = "D2", TenDichTruyen = "Ringer lactat"},
            //        new DATABASE.Other.MaHoaDichTruyen(){MaDichTruyen = "D3", TenDichTruyen = "Glucose 5%"},
            //        new DATABASE.Other.MaHoaDichTruyen(){MaDichTruyen = "D4", TenDichTruyen = "Glucose 20%"},
            //        new DATABASE.Other.MaHoaDichTruyen(){MaDichTruyen = "D5", TenDichTruyen = "Natribicarbonat 14‰"},
            //        new DATABASE.Other.MaHoaDichTruyen(){MaDichTruyen = "D6", TenDichTruyen = "Manitol 20%"},
            //        new DATABASE.Other.MaHoaDichTruyen(){MaDichTruyen = "D7", TenDichTruyen = "Heas-steril 6%"},
            //        new DATABASE.Other.MaHoaDichTruyen(){MaDichTruyen = "D8", TenDichTruyen = "Amigold 8,5%"},
            //        new DATABASE.Other.MaHoaDichTruyen(){MaDichTruyen = "D9", TenDichTruyen = ""},
            //        new DATABASE.Other.MaHoaDichTruyen(){MaDichTruyen = "D10", TenDichTruyen = ""}
            //    };
            //}
            return data;
        }
    }
}