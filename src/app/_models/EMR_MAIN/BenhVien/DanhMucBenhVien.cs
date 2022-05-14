using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMR_MAIN.DATABASE.BenhVien
{
    public class DanhMucBenhVien
    {
        public long ID { get; set; }
        public string MaCSKCB { get; set; }
        public string TenBenhVien { get; set; }
        public string DiaChi { get; set; }
        public string HangBenhVien { get; set; }
        public string LoaiBenhVien { get; set; }
        public string TuyenBenhVien { get; set; }
        public string Tinh { get; set; }
        public string Huyen { get; set; }
        public string Xa { get; set; }
        public string GhiChu { get; set; }
    }
    public class DanhMucBenhVienFunc
    {
        public static void InsertOrUpdate(DanhMucBenhVien danhMucBenhVien, MDB.MDBConnection conn)
        {
            try
            {
                string sql = "Select ID from BenhVien where MaCSKCB = :MaCSKCB";
                MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, conn);
                oracleCommand.Parameters.Add("MaCSKCB", danhMucBenhVien.MaCSKCB);
                MDB.MDBDataReader dataReader = oracleCommand.ExecuteReader();
                int rowCount = 0;
                while (dataReader.Read()) rowCount++;
                if (rowCount > 0)
                    sql = "Update BenhVien Set TenBenhVien = :TenBenhVien, DiaChi = :DiaChi, HangBenhVien = :HangBenhVien, LoaiBenhVien = :LoaiBenhVien, TuyenBenhVien = :TuyenBenhVien, Tinh = :Tinh, Huyen = :Huyen, Xa = :Xa, GhiChu = :GhiChu WHERE MaCSKCB = :MaCSKCB";
                else
                    sql = "Insert Into BenhVien (TenBenhVien, DiaChi, HangBenhVien, LoaiBenhVien, TuyenBenhVien, Tinh, Huyen, Xa, GhiChu, MaCSKCB) Values (:TenBenhVien, :DiaChi, :HangBenhVien, :LoaiBenhVien, :TuyenBenhVien, :Tinh, :Huyen, :Xa, :GhiChu, :MaCSKCB)";
                oracleCommand = new MDB.MDBCommand(sql, conn);
                oracleCommand.Parameters.Add("TenBenhVien", danhMucBenhVien.TenBenhVien);
                oracleCommand.Parameters.Add("DiaChi", danhMucBenhVien.DiaChi);
                oracleCommand.Parameters.Add("HangBenhVien", danhMucBenhVien.HangBenhVien);
                oracleCommand.Parameters.Add("LoaiBenhVien", danhMucBenhVien.LoaiBenhVien);
                oracleCommand.Parameters.Add("TuyenBenhVien", danhMucBenhVien.TuyenBenhVien);
                oracleCommand.Parameters.Add("Tinh", danhMucBenhVien.Tinh);
                oracleCommand.Parameters.Add("Huyen", danhMucBenhVien.Huyen);
                oracleCommand.Parameters.Add("Xa", danhMucBenhVien.Xa);
                oracleCommand.Parameters.Add("GhiChu", danhMucBenhVien.GhiChu);
                oracleCommand.Parameters.Add("MaCSKCB", danhMucBenhVien.MaCSKCB);
                int x = oracleCommand.ExecuteNonQuery();
                if (x <= 0)
                {
                    MessageBox.Show("Thất bại: " + JsonConvert.SerializeObject(danhMucBenhVien));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public static DanhMucBenhVien GetBenhVien(string MaCSKCB, MDB.MDBConnection conn)
        {
            DanhMucBenhVien danhMucBenhVien = new DanhMucBenhVien();
            try
            {
                string sql = "Select * from BenhVien Where MaCSKCB = :MaCSKCB";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, conn);
                command.Parameters.Add("MaCSKCB", MaCSKCB);
                MDB.MDBDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    danhMucBenhVien.ID = Convert.ToInt64(dataReader.GetLong("ID"));
                    danhMucBenhVien.MaCSKCB = dataReader["MaCSKCB"].ToString();
                    danhMucBenhVien.TenBenhVien = dataReader["TenBenhVien"].ToString();
                    danhMucBenhVien.DiaChi = dataReader["DiaChi"].ToString();
                    danhMucBenhVien.HangBenhVien = dataReader["HangBenhVien"].ToString();
                    danhMucBenhVien.LoaiBenhVien = dataReader["LoaiBenhVien"].ToString();
                    danhMucBenhVien.TuyenBenhVien = dataReader["TuyenBenhVien"].ToString();
                    danhMucBenhVien.Tinh = dataReader["Tinh"].ToString();
                    danhMucBenhVien.Huyen = dataReader["Huyen"].ToString();
                    danhMucBenhVien.Xa = dataReader["Xa"].ToString();
                    danhMucBenhVien.GhiChu = dataReader["GhiChu"].ToString();
                    break;
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return danhMucBenhVien;
        }
        public static List<DanhMucBenhVien> GetAllBenhVien(MDB.MDBConnection conn)
        {
            List<DanhMucBenhVien> dmBenhVien = new List<DanhMucBenhVien>();
            try
            {
                string sql = "Select * from BenhVien";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, conn);
                MDB.MDBDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    DanhMucBenhVien benhVien = new DanhMucBenhVien();
                    benhVien.ID = Convert.ToInt64(dataReader.GetLong("ID"));
                    benhVien.MaCSKCB = dataReader["MaCSKCB"].ToString();
                    benhVien.TenBenhVien = dataReader["TenBenhVien"].ToString();
                    benhVien.DiaChi = dataReader["DiaChi"].ToString();
                    benhVien.HangBenhVien = dataReader["HangBenhVien"].ToString();
                    benhVien.LoaiBenhVien = dataReader["LoaiBenhVien"].ToString();
                    benhVien.TuyenBenhVien = dataReader["TuyenBenhVien"].ToString();
                    benhVien.Tinh = dataReader["Tinh"].ToString();
                    benhVien.Huyen = dataReader["Huyen"].ToString();
                    benhVien.Xa = dataReader["Xa"].ToString();
                    benhVien.GhiChu = dataReader["GhiChu"].ToString();
                    dmBenhVien.Add(benhVien);
                }
                dataReader.Close();
                dataReader = null;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return dmBenhVien;
        }
    }
}
